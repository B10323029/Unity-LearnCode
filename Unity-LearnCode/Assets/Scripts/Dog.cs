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
    public void Bark()
    {
        Debug.Log(name + ":汪汪!!")
    }
    #endregion

}

public class DogAction
{

}