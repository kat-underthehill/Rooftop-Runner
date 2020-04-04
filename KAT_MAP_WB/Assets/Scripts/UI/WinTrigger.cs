using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text text;
    public Button button;
    public PlayerController player;
    private CharacterController cc;

    void Start()
    {
        cc = player.GetComponent<CharacterController>();
    }


    void OnTriggerEnter(Collider other)
    {
        text.gameObject.SetActive(true);
        //button.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
        cc.enabled = false;
    }
}
