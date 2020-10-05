using Microsoft.VisualStudio.TestTools.UnitTesting;
using Input_Reversal;
namespace ReverseStringTest
{
    [TestClass]
    public class ReverseInput
    {
        /// <summary>
        /// This method checks the input for a blank string.
        /// </summary>
        [TestMethod]
        public void checkStringEmpty()
        {
            string emptyString = "";
            InputReverse.inputReverse(emptyString);
        }

        /// <summary>
        /// This method checks the input for only spaces.
        /// </summary>
        [TestMethod]
        public void checkStringContainsOnlySpaces()
        {
            string spacesString = "              ";
            InputReverse.inputReverse(spacesString);
        }

        /// <summary>
        /// Tis method checks the input for the decimal values.
        /// </summary>
        [TestMethod]
        public void checkFloatNumberReverse()
        {
            string floatString = 123.321.ToString();
            InputReverse.inputReverse(floatString);
        }

        /// <summary>
        /// This method checks the input for a number.
        /// </summary>
        [TestMethod]
        public void checkIntegerReverse()
        {
            string integerString = 2458712238.ToString();
            InputReverse.inputReverse(integerString);
        }

        /// <summary>
        /// This method checks the input for a single character.
        /// </summary>
        [TestMethod]
        public void checkSingleCharacterReverse()
        {
            string characterString = "c";
            InputReverse.inputReverse(characterString);
        }

        /// <summary>
        /// This method checks the input for a string.
        /// </summary>
        [TestMethod]
        public void checkStringReverse()
        {
            string regularString = "apurva";
            InputReverse.inputReverse(regularString);
        }

        /// <summary>
        /// This method checks the input for a sentence.
        /// </summary>
        [TestMethod]
        public void checkSentenceReverse()
        {
            string sentenceString = "This is my Unit Testing Project.";
            InputReverse.inputReverse(sentenceString);
        }

        /// <summary>
        /// This method checks the input for special characters.
        /// </summary>
        [TestMethod]
        public void checkSpecialCharacterReverse()
        {
            string specialCharacterString = "@!*&kfjsh$";
            InputReverse.inputReverse(specialCharacterString);
        }

        /// <summary>
        /// This method checks the input for palindrome string.
        /// </summary>
        [TestMethod]
        public void checkPalindromeStringReverse()
        {
            string palindromeStringReverse = "madam";
            InputReverse.inputReverse(palindromeStringReverse);
        }
    }
}
