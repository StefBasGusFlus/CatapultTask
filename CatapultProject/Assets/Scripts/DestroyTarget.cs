using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyTarget : MonoBehaviour
{
    [SerializeField] private Text _win;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Attack")
        {
            Destroy(gameObject);
            _win.text = "Выиграл!";
        }
           
    }
}
