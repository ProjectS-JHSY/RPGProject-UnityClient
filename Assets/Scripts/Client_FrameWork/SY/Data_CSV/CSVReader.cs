using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

public class CSVReader 
{
    protected static string SPLIT_RE = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))";
    protected static string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";
    protected static char[] TRIM_CHARS = { '\"' };
    protected static string _base_path = "Release_Data/";
    protected static string _design_path = "GameDesign_Data/";
    protected static string _test_path = "Dev_Data/";



    protected static string getBasetPath()
    {
#if UNITY_EDITOR
        return Application.dataPath + "/Resources/";
#elif UNITY_ANDROID
            return Application.persistentDataPath+_filename;
#elif UNITY_IPHONE
            return Application.persistentDataPath+"/"+_filename;
#else
            return Application.dataPath +"/"+_filename;
#endif
    }


    //==========================================================
    //: common function for reading
    //==========================================================
    public static string[] Read_Lines(string file)
    {

        char[] splitter1 = { '/' };
        char[] splitter2 = { '?' };

        TextAsset data = Resources.Load(_base_path + file) as TextAsset;
        if (data == null) return null;
        List<string> fieldnameList = new List<string>();

        var lines = Regex.Split(data.text, LINE_SPLIT_RE);
        return lines;
    }

    public static string[] Make_Header(string header_line)
    {
        var header = Regex.Split(header_line, SPLIT_RE);
        return header;
    }

    public static int Make_Int(string datum)
    {
        if (datum == "")
            return 0;
        //NN.Debugger.Debug("datum =====" + datum);
        int value = int.Parse(datum);
        return value;
    }
    public static float Make_Float(string datum)
    {
        if (datum == "")
            return 0.0f;
        float value = float.Parse(datum);
        return value;
    }
    public static bool Make_Bool(string datum)
    {
        if (datum == "")
            return false;
        if (datum.ToUpper() == "TRUE")
            return true;
        if (datum.ToUpper() == "FALSE")
            return false;

        bool rvalue = false;
        try
        {
            int value = int.Parse(datum);
            rvalue = Convert.ToBoolean(value);
        }
        catch (Exception e)
        {
            return false;
        }
        return rvalue;
    }
    /// <summary>
    /// Read Unit Data...
    /// </summary>
    public static Dictionary<int , Unit_Data> Read_Unit_data(string file)
    {
        var list = new Dictionary<int, Unit_Data>();
        var lines = Read_Lines(file);
        if (lines.Length < 1) return list;
        var header = Make_Header(lines[0]);
        for (int i = 0; i < lines.Length; i++)
        {
            var values = Regex.Split(lines[i], SPLIT_RE);
            if (values.Length == 0 || values[0] == "") continue;
            Unit_Data tmp_unitdata = new Unit_Data();
            tmp_unitdata.id = Make_Int(values[0]);
            tmp_unitdata.res_name_id = Make_Int(values[1]);
            tmp_unitdata.Desc = Make_Int(values[2]);
            tmp_unitdata.Unit_Hp = Make_Int(values[3]);
            tmp_unitdata.Unit_stamina = Make_Int(values[4]);
            tmp_unitdata.Unit_Atk = Make_Int(values[5]);
            tmp_unitdata.Unit_Def = Make_Int(values[6]);
            tmp_unitdata.Unit_AtkSpeed = Make_Int(values[7]);
        }
        return list;
    }
    
    ///
    /// Read Buliding Data
    ///



    ///
    /// Read World Data
    ///
}
