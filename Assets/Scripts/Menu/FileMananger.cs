using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UnityEngine;

public class FileMananger : MonoBehaviour
{
    public static Data_game data;
    public DataLVL1 dat;
    private void Awake()
    {
        
    }
    public void Save()
    {
        Data_game JSONSER = new Data_game();
        string data = JsonUtility.ToJson(JSONSER);
        File.WriteAllText(Application.streamingAssetsPath + "/Loadsave.json", data);
    }
    public Data_game Load(string Data)
    {
        Data_game JSONDESER = JsonUtility.FromJson<Data_game>(File.ReadAllText(Application.streamingAssetsPath + "/" + Data + ".json"));
        return JSONDESER;
    }
    public void DataLVL_return(string data)
    {
        Data_game a = Load(data);
        int h = a.h;
        int w = a.w;
        dat.h = h;
        dat.w = w;
        int[,] map = new int[h, w];
        string[] q = a.map.Split(" ");
        for(int i = 0; i < h; i++)
        {
            for(int j = 0; j < w; j++)
            {
                int refer = Convert.ToInt32(q[i].Split("")[j]);
                map[i, j] = refer;
            }
        }
        dat.map = map;
        dat.count_box = a.count_box;
        string[] d = a.pos_box.Split("*");
        for(int i =0; i < d.Length; i++)
        {
            dat.pos_box[i] = new Vector2(Convert.ToInt32(d[i].Split("")[0]), Convert.ToInt32(d[i].Split("")[1]));
        }
        dat.pos_player = new Vector2(Convert.ToInt32(a.pos_player.Split(" ")[0]), Convert.ToInt32(a.pos_player.Split(" ")[0]));
    }
}
[Serializable]
public class Data_game
{
    public string map;
    public int h;
    public int w;
    public int count_box;
    public string pos_player;
    public string pos_box;
}

