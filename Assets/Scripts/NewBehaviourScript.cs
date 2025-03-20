using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject box;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log($"碰到地板");
        // other.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // GameObject hand = GameObject.Find("Hand"); // 尋找名為Hand遊戲物件，並儲存為區域變數
        Debug.Log($"進入偵測區域");
        // GameObject box = GameObject.Find("寶箱");
        box.SetActive(true);
        // GameObject.Find("寶箱").SetActive(true);
        // gameObject.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log($"離開偵測區域");
    }
}
