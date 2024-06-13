namespace TestDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void cifrado ()
    {
        string word = "Z123";
        int k = 3 ;
        string expectedResult = "3456";

        string respuesta = Algorithm.cifrado(word,k);

        Assert.Equal (expectedResult, respuesta);
        
    }

    [Fact]
    
    public void descifrado()

    {
        string word = "MTPF";
        int k = 5;

        string expectedResult = "HOLA";

        string result2 = Algorithm.descifrado (word, k);

        Assert.Equal (expectedResult, result2); 

    }

    [Fact]
    public void cifrado_Examen()

    {
        // Given
        string word = "JOSEALFREDO123";
        int k = 3;
        string respuesta = Algorithm.cifrado(word,k);
        string expectedResult = "MRVHDÑIUHGR456";
        // When
        Assert.Equal (expectedResult, respuesta);
    
        // Then
    }

    [Fact]
    public void decifrado_test()
    {

    string word = "MRVHDÑIUHGR456";
    int k = 3;
    string result2 = Algorithm.descifrado (word, k);
    string expectedResult2 = "JOSEALFREDO123";

    Assert.Equal(expectedResult2, result2);

    }

 

}
