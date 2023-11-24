using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mananger : MonoBehaviour, IMananger
{
    public Tile[] tiles;
    public Box[] boxes;
    public Player player;
    public Generator gen;
    public DynamicJoystick joy;
    FinishMananger man;
    public GameObject Cam_menu, Cam_Lvl, panel;
    public static Action back, res;
    public Button Back_, re1, re2;
    public Transform start_pos;
    public FileMananger file;
    public DataLVL1 data;

    Generator generator;
    private void Start()
    {
        

        Back_.onClick.AddListener(Return_menu);
        re1.onClick.AddListener(Restart);
        re2.onClick.AddListener(Restart);
        man = GetComponent<FinishMananger>();
        ManangerLvL.Start_LVL1 += gener;
    }
    public void gener()
    {

        man.n = 3;
        player.joystick = joy;
        Box[] box_box = new Box[3] { boxes[0], boxes[0], boxes[0] };
        generator = Instantiate(gen);
        int[,] x = new int[13, 12] { 
            { 0,0,0,0,0,0,0,0,0,0,0,0 },
            { 4,3,3,3,3,3,5,5,5,5,5,0 }, 
            { 4,3,1,1,1,1,5,5,5,5,5,0 }, 
            { 4,3,1,1,1,1,5,5,5,5,5,0 }, 
            { 4,3,3,3,3,3,5,5,5,5,5,0 },
            { 0,5,5,5,5,5,5,5,5,5,5,0 },
            { 0,5,5,5,5,5,5,5,5,5,5,0 },
            { 0,0,0,0,0,0,1,1,0,0,0,0 },
            { 0,2,1,1,0,1,1,1,1,1,1,0 },
            { 0,2,1,1,0,1,1,1,6,1,1,0 },
            { 0,2,1,1,1,1,1,1,1,1,1,0 },
            { 0,1,1,1,1,1,1,1,1,1,1,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0 }
        };
        Vector2[] vector2s = new Vector2[3] {new Vector2(3,3), new Vector2(5, 2), new Vector2(9, 3) };
        generator.init(13, 12, x, new Vector2(7,3), box_box, vector2s, player, tiles);
        generator.Generator_Map();
        generator.Generator_Player();
        generator.Generator_Box();
    }
    public void Ungenerator()
    {
        generator.DeliteMap();
    }
    public void Return_menu()
    {
        panel.transform.position = start_pos.position;
        Ungenerator();
        Cam_menu.SetActive(true);
        Cam_Lvl.SetActive(false);
        back.Invoke();
    }
    public void Restart()
    {
        Ungenerator();
        gener();
        panel.transform.position = start_pos.position;
    }


}
