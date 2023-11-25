using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CreaterManenge : MonoBehaviour
{
    public Tile[] tiles;
    public Box[] boxes;
    public Player player;
    public Camera cam;
    int in_heand;
    public Button e1, e2, e3, e4,e5, save;
    public Data map;
    public GameObject menu, roomer, room;

    Tile heand;
    Generator gen;
    Vector2[] a = new Vector2[] { };
    void Start()
    {
        MenuCreater.Creater += gener;
        Mananger.open1 += () => e3.gameObject.SetActive(true);
        Tile.toclick += removeTile;
        e1.onClick.AddListener(() => rev(0, tiles[0]));
        e2.onClick.AddListener(() => rev(1, tiles[1]));
        e3.onClick.AddListener(() => rev(2, tiles[2]));
        e4.onClick.AddListener(() => rev(3, tiles[3]));
        e5.onClick.AddListener(() => rev(4, tiles[4]));
        save.onClick.AddListener(Save);

        gen = GetComponent<Generator>();

        
        heand = tiles[0];
        in_heand = 0;

    }
    private void Update()
    {
        
    }
    void gener()
    {
        int[,] map = new int[10, 10] {
            {0,0,0,0,0,0,0,0,0,0},
            {0,1,1,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,0},
            {0,1,1,1,1,1,1,1,1,0},
            {0,0,0,0,0,0,0,0,0,0}
        };
        gen.init(10, 10, map, new Vector2(1, 1), boxes, a, player, tiles);
        gen.Generator_Map();

    }
    void removeTile(GameObject a)
    {
        
            //a.GetComponent<Image>().color = Color.black;
            gen.map[(int)a.transform.position.x, (int)a.transform.position.y] = in_heand;
            Instantiate(heand, a.transform.position, Quaternion.identity);
        a.SetActive(false);
        gen.ActivEl.Add(a.GetComponent<Tile>());
        
    } 
    void rev(int a, Tile b)
    {
        in_heand = a;
        heand = b;
    }
    void Save()
    {

        map.map = gen.map;
        gen.DeliteMap();
        menu.SetActive(true);
        roomer.SetActive(false);
        room.SetActive(true);
    }

}
