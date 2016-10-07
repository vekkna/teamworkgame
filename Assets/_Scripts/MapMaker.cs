using UnityEngine;

public class MapMaker : MonoBehaviour {

    [SerializeField]
    GameObject grass;
    [SerializeField]
    GameObject[] elements;

    void Start() {
        MakeMap();
    }

    public void MakeMap() {

        float width = grass.GetComponent<Renderer>().bounds.size.x;

        Debug.Log("width:" + width);

    }


}
