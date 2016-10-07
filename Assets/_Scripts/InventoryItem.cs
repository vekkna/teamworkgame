using System;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour {

    public enum Type {
        gem, key
    }

    public Type type;
    public Ingredient ingredient;

    Image image;
    CanvasGroup canvas;

    void Awake() {
        image = GetComponent<Image>();
        canvas = GetComponent<CanvasGroup>();
    }

    public void Show(Gem gem) {
        image.color = gem.GetColor();
        canvas.alpha = 1f;
    }

    internal void Hide() {
        canvas.alpha = 0;
    }
}