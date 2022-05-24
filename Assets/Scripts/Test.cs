using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//在装这个组件的时候必定包含某个组件
[RequireComponent(typeof(BoxCollider))]

//在编辑器添加一个用于添加组件的菜单项，将拥有该属性的脚本添加到选中的物体上
[AddComponentMenu("Test1/Test22")]

//若该脚本继承ScriptableObject，可以将此脚本在右键处可以被创建
//把数据真正存储在了资源文件中，可以像其他资源那样管理它，例如退出运行也一样会保持修改
//可以在项目之间很好的复用，不用再制作Prefab那样导入导出
[CreateAssetMenu()]

//禁止该组件在一个对象中存在多个
[DisallowMultipleComponent]

//设置本组件的帮助文档
[HelpURL("https://www.baidu.com")]

//将此属性添加到某个类可防止从该类的实例创建预设值
[ExcludeFromPreset]

public class Test : MonoBehaviour
{
    //让非public的变量可以在unity外部进行修改
    [SerializeField]
    private bool privateValue;

    //强制让sturct class等可以在unity外部显示以进行修改
    [System.Serializable]
    public struct PlayerState
    {
        public int movementSpeed;
        public int hitPoint;
        public bool hasHealthPotion;
    }

    //让public的变量不可以在unity外部进行修改
    [HideInInspector]
    public bool publicValue;

    //不允许该变量被序列化
    [System.NonSerialized]
    public int nonSerializedValue;

    //鼠标在此变量上会显示参数内的信息来提示
    [Tooltip("This is a tip")]

    //让此变量的在Unity上显示的行数为指定的行数
    [Multiline(4)]
    public string tip;

    //在下一个对象前加入高为20个像素的间隔
    [Space(20)]

    //与Multiline类似但是多了滚动视图
    [TextArea]
    public string tip2;

    //用于区分变量的类型，一般用于某种类型变量的开头
    [Header("Other Setting")]

    //限定指定范围
    [Range(0, 1)]
    public float range;

    //限定最小值
    [Min(0)]
    public float speed;

    //不可调整rgba中的透明度
    [ColorUsage(showAlpha: false)]
    public Color color;

    //在Unity中随时调用下面的函数，可以用于初始化场景
    [ContextMenu("DoThings")]
    public void DoSomething()
    {
        Debug.Log("DoSomething");
    }

    //让枚举中的值实际的和在Unity外部显示的不一样，可以让内容更加易于理解
    public ModelImporterIndexFormat indexFormat;
    public enum ModelImporterIndexFormat
    {
        Auto = 0,
        [InspectorName("16 bits")]
        UInt32 = 1,
        [InspectorName("32 bits")]
        UInt64 = 2,
    }
}
