using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RoomController : MonoBehaviour
{
    public CinemachineVirtualCamera[] kameralar;
    public GameObject odaSecimUI;
    public GameObject livingRoomUI;
    public GameObject bedroomUI;
    public GameObject kitchenUI;
    public Button LivingRoomButton;
    public Button BedroomButton;
    public Button KitchenButton;
    public GameObject player;
    public Transform livingRoomPos;
    public Transform bedroomPos;
    public Transform kitchenPos;
    private void Start()
    {
        LivingRoomButton.onClick.AddListener(LivingRoomPopup);
        BedroomButton.onClick.AddListener(BedroomPopup);   
        KitchenButton.onClick.AddListener(KitchenPopup);    
        livingRoomUI.SetActive(true);   
    }
    public void OdayaGit(int index) 
    {
        for(int i = 0; i < kameralar.Length; i++)
        {
            if (i == index)
            {
                kameralar[i].Priority = 10;
            }
            else
            {
                kameralar[i].Priority = 0;
            }
        }
        odaSecimUI.SetActive(false);    
    }
    void LivingRoomPopup()
    {
        player.transform.position = livingRoomPos.position;
        livingRoomUI.SetActive(true);   
        bedroomUI.SetActive(false); 
        kitchenUI.SetActive(false); 
    }
    void BedroomPopup()
    {
        player.transform.position = bedroomPos.position;
        livingRoomUI.SetActive(false);
        kitchenUI.SetActive(false);
        bedroomUI.SetActive(true);
    }
    void KitchenPopup()
    {
        player.transform.position = kitchenPos.position;
        bedroomUI.SetActive(false);
        livingRoomUI.SetActive(false);
        kitchenUI.SetActive(true);
    }

}
