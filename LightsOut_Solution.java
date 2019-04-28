import java.util.Scanner;

/**
 * A solution class to lights out.
 * 
 * Task: Find the fastest way to "clear" the billboard, i.e., to flip all tiles to their white side.
 * 
 * Input: Each case begins with a line containing two integer numbers R and C (1 <= R,C <= 16)
 * specifying the billboard size. Then there are R lines, each containing C characters. The
 * characters can be either an uppercase letter "X" (black) or a dot "." (white). There is one empty
 * line after each case. The input is terminated by two zeros in place of the board size.
 * 
 * Output: For each board, print "You have to tap T tiles.", where T is the minimal possible number
 * of taps needed to make all squares white. If the situation cannot be solved, output the string
 * "Damaged billboard."instead.
 * 
 * @author CSY
 *
 */
public class LightsOut_Solution {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int row, column;
        int answer; // count the minimum step to solve the pattern
        int count; // number of 1 in a particular mask
        int prev;
        int cur;
        int state;
        int S; // a mask full of 1 (the number of 1 depends on the column number)
        char[][] board = new char[16][16];

        while (true) {
            // System.out.println("------Here is the start of one case.------");
            answer = -1;
            row = sc.nextInt();
            column = sc.nextInt();

            // System.out.println(row + " " + column + " rc");

            if (row == 0)
                break;
            if (row < 0 || column < 0 || row > 16 || column > 16) {
                System.out.println("Invalid input.");
                break;
            }

            for (int i = 0; i < row; i++) {
                String tmp = sc.next();
                for (int j = 0; j < column; j++) {
                    board[i][j] = tmp.charAt(j);
                    // System.out.print(board[i][j]+" and " + i+j+" ");
                }
                // System.out.println();
            }

            // System.out.println("Successfully construct the board.");

            S = (1 << column) - 1;
            for (int mask = S; mask >= 0; mask--) {
                count = countOne(mask);
                prev = mask;
                state = (mask ^ (mask >> 1) ^ (mask << 1)) & S;

                for (int c = 0; c < column; c++) {
                    if (board[0][c] == 'X')
                        state ^= (1 << c);
                }

                for (int r = 1; r < row; r++) {
                    cur = state;
                    count += countOne(state);
                    state = (state ^ (state >> 1) ^ (state << 1) ^ prev) & S;
                    prev = cur;

                    for (int c = 0; c < column; c++) {
                        if (board[r][c] == 'X')
                            state ^= (1 << c);
                    }
                }

                if (state == 0 && (answer == -1 || count < answer))
                    answer = count;
            }
            if (answer == -1) // no solution is found
                System.out.println("Damaged billboard.");
            else
                System.out.printf("You have to tap %d tiles.\n", answer);

            // System.out.println("--------this is end of one case--------");
        }
        sc.close();
    }

    /**
     * count the number of 1 in binary representative of input
     * 
     * @param mask
     * @return
     */
    private static int countOne(int mask) {
        int count = 0;
        while (mask > 0) {
            count += mask & 1;
            mask >>= 1;
        }
        return count;
    }
}
