using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class CreatePrefabs
{
    [MenuItem("Create/Animal Prefabs")]
    static void MenuItemOnClick()
    {
        ExampleScript.Create();
    }
}
