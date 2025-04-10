using NUnit.Framework;

public class CSharpPracticeTests
{
    [Test(Description = "兩個數字相加的驗證")]
    [TestCase(2 ,  2 , 4)]
    [TestCase(3 ,  3 , 6)]
    [TestCase(4 ,  4 , 8)]
    [TestCase(-4 , 6 , 2 , Description = "負數加正數")]
    public void Add_Two_Number(int a , int b , int expected)
    {
        // arrange
        CsharpPractice csharpPractice = new CsharpPractice();

        // act
        int result = csharpPractice.Add(a , b);

        // assert
        Assert.AreEqual(expected , result);
    }

    [Test(Description = "取得本地化文字")]
    [TestCase("Apple" , "蘋果")]
    [TestCase("Banana" , "香蕉")]
    public void GetLocalizationText(string key , string expected)
    {
        // arrange
        var csharpPractice = new CsharpPractice();

        // act
        var localizationText = csharpPractice.GetLocalizationText(key);

        // assert
        Assert.AreEqual(expected , localizationText);
    }
}