using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class ExampleScript : MonoBehaviour
{
    public string petToMake;

    static Dictionary<string, System.Type> typeDict;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject newObj = new GameObject();
        //System.Type petType = typeof(Dog);
        //Pet pet = (Pet)newObj.AddComponent(petType);
    }

    public static void Create()
    {
        string[] files = System.IO.Directory.GetFiles(Application.dataPath + "/Resources/Sprites/", "*.png");

        typeDict = new Dictionary<string, System.Type>();

        foreach (string item in files)
        {
            Create(System.IO.Path.GetFileNameWithoutExtension(item));
        }
    }

    public static void Create(string petType)
    {
        GameObject newObj = new GameObject();
        newObj.name = petType;

        System.Type type = Type.GetType(petType);
        Pet pet = (Pet)newObj.AddComponent(type);

        UnityEditor.PrefabUtility.SaveAsPrefabAsset(newObj, "Assets/Resources/Prefabs/"+petType+".prefab");

        DestroyImmediate(newObj);
    }
}
