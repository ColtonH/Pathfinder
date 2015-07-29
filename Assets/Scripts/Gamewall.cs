using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gamewall : MonoBehaviour {

    public Material main_material;

    // Use this for initialization
    void Start () {
        main_material = GetComponent<Renderer>().material;
    }
}
