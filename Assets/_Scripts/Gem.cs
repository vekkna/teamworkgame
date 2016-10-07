using UnityEngine;
using System.Collections.Generic;

public class Gem : MonoBehaviour {



    public Ingredient ingredient;

    [SerializeField]
    Color red, blue, green, yellow;
    Dictionary<Ingredient, Color> coloursDict;

    SpriteRenderer spr;

    void Awake() {
        spr = GetComponent<SpriteRenderer>();
        coloursDict = new Dictionary<Ingredient, Color>();
        coloursDict.Add(Ingredient.red, red);
        coloursDict.Add(Ingredient.blue, blue);
        coloursDict.Add(Ingredient.green, green);
        coloursDict.Add(Ingredient.yellow, yellow);
    }

    void Start() {
        Init(ingredient);
    }

    internal void Init(Ingredient c) {
        ingredient = c;
        spr.color = coloursDict[c];
    }

    public Color GetColor() {
        return coloursDict[ingredient];
    }
}

public enum Ingredient {
    red, blue, green, yellow
}