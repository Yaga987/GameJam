using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public Player pl;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Timer"))
        {
            collectionSoundEffect.Play();
            pl.TakeTime(50);
            Destroy(collision.gameObject);
        }
    }
}
