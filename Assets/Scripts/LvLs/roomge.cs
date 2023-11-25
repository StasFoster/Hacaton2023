using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roomge : MonoBehaviour
{
    public Tile[] tiles;
    public Box[] boxes;
    public Player player;
    Data a;
    public Button room, back;
    public GameObject menu, roomer;
    Generator gen;
    void Start()
    {
        a = GetComponent<Data>();
        gen = GetComponent<Generator>();
        room.onClick.AddListener(gener);
        back.onClick.AddListener(retbeck);

    }
    void gener()
    {
        menu.SetActive(false);
        roomer.SetActive(true);
        gen.init(10, 10, a.map, new Vector2(1, 1), boxes, null, player, tiles);
        gen.Generator_Map();
        gen.Generator_Player();
    }
    void retbeck()
    {
        gen.DeliteMap();
        menu.SetActive(true);
        roomer.SetActive(false);
    }   
}
