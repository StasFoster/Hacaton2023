using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mananger : MonoBehaviour
{
    public Tile[] tiles;
    public Box[] boxes;
    public Player player;
    public Generator gen;
    FinishMananger man;
    Restart rer;


    private void Start()
    {
        ManangerLvL.Start_LVL1 += gener;
        Restart.Res += gener;
    }
    public void gener()
    {
        Debug.Log("123");
        man = GetComponent<FinishMananger>();
        rer = GetComponent<Restart>();
        man.n = 3;
        rer.n = 1;
        Vector2[] pos_box = new Vector2[3] { new Vector2(4, 2), new Vector2(3, 5), new Vector2(8, 4) };
        Box[] box_box = new Box[3] { boxes[0], boxes[0], boxes[0] };
        int[,] x = new int[8, 11] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 2, 1, 1, 1, 1, 0 }, { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 0, 0, 0, 2, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, { 0, 1, 1, 1, 2, 0, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        Generator generator = Instantiate(gen);
        generator.init(8, 11, x, new Vector2(8, 1), box_box, pos_box, player, tiles);
        generator.Generator_Map();
        generator.Generator_Player();
        generator.Generator_Box();
    }


}
