using UnityEngine;


public class DogManager : MonoBehaviour
{
    public Dog DogA = new Dog("公",2);
    public Dog DogB = new Dog("母",3);

    

    #region 事件 
    private void Start()
    {
        DogA.name = "哈哈";
        DogA.weight = 20.6f;
        DogA.type = "哈士奇";
        // DogA.sex = "公";
        DogA.color = "黑";
        // DogA.age = 2;

        DogB.name = "柴柴";
        DogB.weight = 15.8f;
        DogB.type = "柴犬";
        // DogB.sex = "母";
        DogB.color = "棕";
        // DogB.age = 3;

        Debug.Log(DogA.name + "品種：" + DogA.type + "顏色：" + DogA.color);
        Debug.Log(DogB.name + "品種：" + DogB.type + "顏色：" + DogB.color);

        DogA.Bark();
        DogB.Bark();

        Debug.Log(DogA.name + "的實際年齡為：" + DogA.ConverAge());
        Debug.Log(DogB.name + "的實際年齡為：" + DogB.ConverAge());

        DogA.Eat("雞腿");
        DogB.Eat("餅乾", 10);
    }
    #endregion
}
