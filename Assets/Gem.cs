using UnityEngine;
using System.Collections.Generic;

public class Gem : MonoBehaviour {

    internal enum Colour {
        red, blue, green, yellow
    }
    internal Colour colour;

    [SerializeField]
    Color red, blue, green, yellow;
    Dictionary<Colour, Color> coloursDict;
    SpriteRenderer spr;

    void Awake() {
        spr = GetComponent<SpriteRenderer>();
        coloursDict = new Dictionary<Colour, Color>();
    }

    internal void Init(Colour c) {
        spr.color = coloursDict[c];
    }
}