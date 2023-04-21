using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;
using System.IO;
using UnityEngine.UI;
public static class Util_Standard
{
    public static string StringbuilderUtil(string _txt)
    {
        StringBuilder strBd = new StringBuilder(50);
        strBd.Append(_txt);
        string resultTxt = strBd.ToString();
        strBd.Length = 0;
        return resultTxt;
    }


    //=================================================
    //: 게임 Texture 리소스 로딩 및 복제...
    //=================================================
    public static Texture Load_Resource_Texture(string _path, string _resName)
    {
        Texture tmp_Result = null;
        string _resPath = _path + "/" + _resName;

        tmp_Result = Resources.Load(_resPath) as Texture;

        //Texture tmp_Result = (Texture)GameObject.Instantiate(tmp_ResultObj);
        return tmp_Result;
    }

    public static Sprite Load_ResourceAsSprite(string _path, string _resName)
    {
        Sprite tmp_Result = null;
        string _resPath = _path + "/" + _resName;

        tmp_Result = Resources.Load<Sprite>(_resPath);

        //Texture tmp_Result = (Texture)GameObject.Instantiate(tmp_ResultObj);
        return tmp_Result;
    }

    //:3d object load
    public static GameObject Load_ResourceAsGameObject(string _path, string _resName)
    {
        GameObject tmp_Result = null;
        string _resPath = _path + "/" + _resName;

        var obj = Resources.Load(_resPath);
        //Debug.LogError("_resName====>"+ _resName);
        tmp_Result = Resources.Load<GameObject>(_resPath);
        GameObject tmp_Resultobj = GameObject.Instantiate(tmp_Result);
        return tmp_Resultobj;
    }

    public static Sprite Load_ResourceAsSlicedSprite(ref Sprite[] sprites, string _path, int id , int firstID)
    {
        string _resPath = _path;

        if(sprites == null)
            sprites = Resources.LoadAll<Sprite>(_resPath);

        for (int i=0;i<sprites.Length;i++)
		{
            if((id - firstID) == i)
                return sprites[i];
		}

        return null;
    }

    private static Sprite[] UnitSprites = null;
    private static Sprite[] SkillSprites = null;

    //resource/icon/해당 리소스 icon을 불러오는 함수

    public static Sprite Load_resource_Unit_Sprites(int _id)
	{
        Sprite _spr = Load_ResourceAsSlicedSprite(ref UnitSprites,"Icon/Icon_unit",_id,1001);
        return _spr;
    }

    public static Sprite Load_resource_Skill_Sprites(int _id)
    {
        Sprite _spr = Load_ResourceAsSlicedSprite(ref SkillSprites, "Icon/Icon_skill", _id, 11);
        return _spr;
    }

    public static Sprite Load_resource_Unit_Sprites(string _resname)
    {
        //ex) icon_unit_11 <====== 유닛 스프라이트 저장할떄...
        string _sprname = StringbuilderUtil("icon_" + _resname);
        Sprite _spr = Load_ResourceAsSprite("Icon/Icon_unit",_sprname);
        return _spr;
    }
   
}
