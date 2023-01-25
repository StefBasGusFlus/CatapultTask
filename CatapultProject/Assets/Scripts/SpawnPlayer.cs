using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Text _win;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_player, transform.position, transform.rotation);
            _win.text = "";
        }
    }
}
