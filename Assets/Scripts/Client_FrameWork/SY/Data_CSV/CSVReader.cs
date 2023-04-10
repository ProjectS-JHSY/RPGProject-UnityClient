using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVReader 
{
   
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

}
