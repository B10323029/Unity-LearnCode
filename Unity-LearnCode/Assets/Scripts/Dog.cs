using UnityEngine;

public class Dog
{
        
    #region Dog 欄位設定
    public string name;
    public float weight;
    public string ty
pe;
    public string sex;
    public string color;
    public int age;
    #endregion

    #region 方法
    /// <summary>
    /// 狗狗叫的方法。
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + ":汪汪!!")
    }

    /// <summary>
    /// 轉換狗狗年齡的方法。
    /// </summary>
    /// <returns>狗狗年齡*7</returns>
    public int ConverAge()
    {
        return age * 7;
    }



    #endregion

}

public class DogAction
{

}