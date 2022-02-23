using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalera : MonoBehaviour
{
    private Collider2D myCollider;
    public GestorDeNiveles gestorDeNiveles;

    private void Start()
    {
        myCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        gestorDeNiveles.CargarSiguienteEscena();
    }

}
