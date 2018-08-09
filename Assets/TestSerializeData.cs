//------------------------------------------------------------------------------------------------------------
//-----------------------------------generate file 2018-08-08 15:29:25----------------------------------------
//------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using UnityEngine;

public class TestSerializeData : ScriptableObject
{
    public List<Test> DataList = new List<Test>();
}

[System.Serializable]
public class Test
{
    public int Id;
    public string Str = "";
}
