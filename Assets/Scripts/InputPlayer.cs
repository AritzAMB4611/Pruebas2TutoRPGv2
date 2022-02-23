using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    [HideInInspector] public float ejeHorizontal { get; set; }
    [HideInInspector] public float ejeVertical { get; set; }
    [HideInInspector] public bool atacar { get; set; }
    [HideInInspector] public bool habilidad1 { get; set; }
    [HideInInspector] public bool habilidad2 { get; set; }
    [HideInInspector] public bool inventario { get; set; }
    [HideInInspector] public bool interactuar { get; set; }

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        atacar = Input.GetButtonDown("Atacar");
        habilidad1 = Input.GetButtonDown("Habilidad1");
        habilidad2 = Input.GetButtonDown("Habilidad2");
        inventario = Input.GetButtonDown("Inventario");
        interactuar = Input.GetButtonDown("Interactuar");

        ejeHorizontal = Input.GetAxis("Horizontal");
        ejeVertical = Input.GetAxis("Vertical");
    }

}
