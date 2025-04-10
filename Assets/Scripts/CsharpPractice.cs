using System.Collections.Generic;
using UnityEngine;

public class CsharpPractice
{
    public int Add(int a , int b)
    {
        return a + b;
    }

    /// <summary>
    /// Key , Value
    /// 英文 , 中文
    /// </summary>
    private Dictionary<string , string> localizationTexts = new Dictionary<string , string>()
    {
        { "Apple" , "蘋果" } , { "Banana" , "香蕉" } ,
    };

    public string GetLocalizationText(string key)
    {
        return localizationTexts[key];
        // if (key == "Apple")
        // {
        //     return "蘋果";
        // }
        //
        // if (key == "Banana")
        // {
        //     return "香蕉";
        // }
        //
        // return "";
    }
}