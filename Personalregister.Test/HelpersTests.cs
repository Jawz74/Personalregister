using Personalregister;

namespace Personalregister.Test
{
    public class HelpersTests
    {
        [Fact]
        public void ReadDecimalInputTest()
        {
           
            string input = "250\n"; // simulera att användaren skriver "250" + Enter
            Console.SetIn(new StringReader(input)); // ger Console.ReadLine() detta värde

            
            decimal result = Helpers.ReadDecimalInput(
                prompt: "Enter value: ",
                min: 100,
                max: 300,
                errorMessage: "Invalid!"
            );

            
            Assert.Equal(250m, result);

        }
    }
}
