using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class Generator : MonoBehaviour
{
    Tile[] tiles;
    int width, height;
    Vector2 pos_player;
    Vector2[] pos_box;
    Player player;
    Player ActivePlayer;
    Box[] boxes;
    int[,] map;
    List<Tile> ActivEl;
    private void Awake()
    {
        ActivEl = new List<Tile>();
        Subscribe_Events();
    }

    public void init(int width, int height, int[,] map, Vector2 pos_player, Box[] boxes, Vector2[] pos_box, Player player, Tile[] tiles)
    {
        this.width = width;
        this.height = height;
        this.map = map;
        this.pos_player = pos_player;
        this.pos_box = pos_box;
        this.player = player;
        this.boxes = boxes;
        this.tiles = tiles;
    }
    public void Generator_Map()
    {
        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                Tile a  = Instantiate(tiles[map[x,y]], new Vector2(y, x), Quaternion.identity);
                ActivEl.Add(a);
            }
        }
    }
    public void Generator_Player()
    {
        Player a = Instantiate(player, pos_player, Quaternion.identity);
        ActivePlayer = a;
    }
    public void Generator_Box()
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            Box a = Instantiate(boxes[i], pos_box[i], Quaternion.identity);
            ActivEl.Add(a);
        }
    }
    void Subscribe_Events()
    {

    }
    public void DeliteMap()
    {
        foreach(Tile a in ActivEl) Destroy(a.gameObject);
        Destroy(ActivePlayer.gameObject);
    }
}
