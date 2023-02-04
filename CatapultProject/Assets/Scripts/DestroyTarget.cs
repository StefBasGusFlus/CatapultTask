using UnityEngine;
using UnityEngine.UI;

public class DestroyTarget : MonoBehaviour
{
    [SerializeField] private Text _win;
    [SerializeField] private AudioSource _audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Attack")
        {
            Destroy(gameObject);

            _win.text = "Выиграл!";

            _audioSource.Play();
        }
    }
}
