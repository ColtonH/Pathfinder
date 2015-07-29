﻿using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class GameboardSquare : MonoBehaviour {

    public Gamewall Top_wall;
    public Gamewall Bottom_wall;
    public Gamewall Left_wall;
    public Gamewall Right_wall;
    public GameLocal CenterSquare;

    public int _x_game_location;
    public int _y_game_location;

    public List<Color> color_list;

    private bool _mouseDown;

	// Use this for initialization
	void Start () {
        _x_game_location = int.Parse(this.gameObject.name.Split(' ').Last());
        _y_game_location = int.Parse(this.gameObject.GetComponentInParent<Gamerow>().name.Split(' ').Last());
	}

    void OnMouseDown()
    {
        Debug.Log("Square " + _x_game_location + ", " + _y_game_location + " chosen.");

        Top_wall.main_material.color = color_list[1];
        Bottom_wall.main_material.color = color_list[1];
    }
}
