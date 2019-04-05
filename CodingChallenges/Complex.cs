/****
**  The function IsComplex() that takes one string argument and
**  returns true or false depending on if the string is an valid complex number.
**  Per Wikipedia, a complex number is a number that can be expressed in the form a + bi,
**  where a and b are real numbers, and i is a solution of the equation x² = −1. 
**  Because no real number satisfies this equation, i is called an imaginary number.
**
**  IsComplex("5+2i") => true
**  IsComplex("5") => false
**
**  Notes:
**      - you are NOT allowed to use the System.Convert class, int.Parse
**        or any other class that converts the string for you
**      - you are NOT allowed to cast to int and catch exception
**      - you MUST figure out a way to parse this by iterating the characters
****/

namespace CodingChallenges
{
    using System;

    public static class Complex
    {
        public static bool IsComplex(string number)
        {
            // TODO Add implementation
            return false;
        }
    }
}
