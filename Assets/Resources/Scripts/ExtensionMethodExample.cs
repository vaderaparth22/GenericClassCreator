using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethodExample
{
    public static void SetRandomColor(this Color myColor)
    {
        myColor = new Color
            (
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
            );
    }

    public static void LookAtYAxis(this Transform myTransform, Vector3 pos)
    {
        Vector3 dir = pos - myTransform.position;
        myTransform.rotation = Quaternion.LookRotation(dir);
    }

    public static float Distance(this Vector3 from, Vector3 to)
    {
        return Vector3.Distance(from, to);
    }

    public static T GetNewRandomElement<T>(this T[] myArr)
    {
        return myArr[Random.Range(0, myArr.Length)];
    }

    public static int ParseToInt(this string myVar)
    {
        return int.Parse(myVar);
    }
}
