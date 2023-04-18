using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public class CSVReader 
{
    protected static string SPLIT_RE = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))";
    protected static string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";
    protected static char[] TRIM_CHARS = { '\"' };
    protected static string _base_path = "CSV/";
  



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
    public static string[] Read_Lines(string file, bool _isuserdata)
    {

        string[] lines;
        string _path = "";

        if (!_isuserdata)
        {
            //: static data 인 경우 ...
            _path = Util_Standard.StringbuilderUtil(getBasetPath() + _base_path + file );
        }
        else
        {
            //: user data 인 경우 ...
            _path = Util_Standard.StringbuilderUtil(getBasetPath() + "/" + file + ".csv");
        }


        if (File.Exists(_path))
        {
            string source;
            StreamReader sr = new StreamReader(_path);
            source = sr.ReadToEnd();
            sr.Close();

            lines = Regex.Split(source, LINE_SPLIT_RE);

            Debug.Log("Load " + file);
        }
        else
        {
            return null;
        }

        if (lines.Length <= 1) return lines;

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

    public static EnumType.eGrade Make_eGrade(string datum)
    {
        var rvalue = (EnumType.eGrade)Enum.Parse(typeof(EnumType.eGrade), datum);
        return rvalue;
    }




    /// <summary>
    /// Read Unit Data...
    /// </summary>
    public static Dictionary<int , Unit_Data> Read_Unit_data(string file)
    {
        var list = new Dictionary<int, Unit_Data>();
        var lines = Read_Lines(file, false);
        if (lines.Length < 1) return list;
        var header = Make_Header(lines[0]);
        for (int i = 1; i < lines.Length; i++)
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
            tmp_unitdata.unitgrade = Make_eGrade(values[8]);
            tmp_unitdata.Level = Make_Int(values[9]);


            list.Add(tmp_unitdata.id, tmp_unitdata);
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
