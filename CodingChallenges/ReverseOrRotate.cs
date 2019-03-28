/****
**  The input is a string str of digits. Cut the string into chunks
**  (a chunk here is a substring of the initial string) of size sz
**  (ignore the last chunk if its size is less than sz).
**
**  If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2,
**  reverse that chunk; otherwise rotate it to the left by one position. Put together these modified
**  hunks and return the result as a string.
**
**  If:
**      - sz is <= 0 or if str is empty return ""
**      - sz is greater (>) than the length of str it is impossible to take a chunk of size sz hence return "".
**
**  Examples:
**      - Compute("123456 987654", 6) --> "234561 876549"
**      - Compute("123456 987653", 6) --> "234561 356789"
**      - Compute("66443875", 4) --> "44668753"
**      - Compute("66443875", 8) --> "64438756"
**      - Compute("664438769", 8) --> "67834466"
**      - Compute("123456779", 8) --> "23456771"
**      - Compute("", 8) --> ""
**      - Compute("123456779", 0) --> "" 
**      - Compute("5630 00655 7344 6948 5", 4) --> "0365 0650 7345 6944"
****/

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class ReverseOrRotate
    {
        public static string Compute(string str, int sz)
        {
            // TODO Add implementation
            return null;
        }
    }
}
