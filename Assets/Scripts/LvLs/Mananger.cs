using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mananger : MonoBehaviour
{
    public Tile[] tiles;
    public Box[] boxes;
    public Player player;
    public Generator gen;
    FinishMananger man;
    Restart rer;
    public GameObject Cam_menu, Cam_Lvl, panel;
    public static Action back, res;
    public Button Back_, re1, re2;
    public Transform start_pos;

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
        Vector2[] pos_box = new Vector2[3] { new Vector2(4, 2), new Vector2(3, 5), new Vector2(8, 4) };
        Box[] box_box = new Box[3] { boxes[0], boxes[0], boxes[0] };
        int[,] x = new int[8, 11] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 2, 1, 1, 1, 1, 0 }, { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 0, 0, 0, 2, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, { 0, 1, 1, 1, 2, 0, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        generator = Instantiate(gen);
        generator.init(8, 11, x, new Vector2(8, 1), box_box, pos_box, player, tiles);
        generator.Generator_Map();
        generator.Generator_Player();
        generator.Generator_Box();
    }
    void Ungenerator()
    {
        generator.DeliteMap();
    }
    void Return_menu()
    {
        panel.transform.position = start_pos.position;
        Ungenerator();
        Cam_menu.SetActive(true);
        Cam_Lvl.SetActive(false);
        back.Invoke();
    }
    void Restart()
    {
        Ungenerator();
        gener();
        panel.transform.position = start_pos.position;
    }


}
