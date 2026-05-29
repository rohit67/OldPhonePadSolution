using OldPhonePadLibrary;

namespace OldPhonePadTests;

public class UnitTest1
{
    [Fact]
    public void Should_Return_E()
    {
        string result = OldPhonePadDecoder.Decode("33#");

        Assert.Equal("E", result);
    }

    [Fact]
    public void Should_Return_B()
    {
        string result = OldPhonePadDecoder.Decode("227*#");

        Assert.Equal("B", result);
    }

    [Fact]
    public void Should_Return_HELLO()
    {
        string result = OldPhonePadDecoder.Decode("4433555 555666#");

        Assert.Equal("HELLO", result);
    }

    [Fact]
    public void Should_Return_CAB()
    {
        string result = OldPhonePadDecoder.Decode("222 2 22#");

        Assert.Equal("CAB", result);
    }

    [Fact]
    public void Should_Handle_Empty_Input()
    {
        string result = OldPhonePadDecoder.Decode("#");

        Assert.Equal("", result);
    }

    [Fact]
    public void Should_Handle_Backspace()
    {
        string result = OldPhonePadDecoder.Decode("8 88777444666*664#");

        Assert.Equal("TURING", result);
    }
}