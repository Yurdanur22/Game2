using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]   
public class Object
{
    public GameObject item;
}
public class ActionController : MonoBehaviour
{
    //[SerializeField] private List<Object> itemsToHold = new List<Object>();
    //public GameObject pickable;

    public GameObject _foodsPopup;
    public GameObject hamburger;
    public GameObject dinner;
    public GameObject carrot;
    public GameObject cheese;
    public GameObject throwButton;
    public GameObject garbageButton;
    public GameObject TableBurger;
    public GameObject TableDinner;
    public GameObject TableCarrot;
    public GameObject TableCheese;
    public bool isBurger = false;
    public bool isDinner = false;
    public bool isCarrot = false;
    public bool isCheese = false;
    public bool isFull = false;
    public bool isHand = false;
    public bool isGarbage = false;

    //public bool isTaked = false;
   // public bool isPickable = false;

   /* private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Sphere"))
        {
            isPickable = true;
        }
    }
    private void Update()
    {
        if(isPickable && Input.GetKey(KeyCode.Space))
        {
            pickable.SetActive(false);
            isTaked = true;
            TakeItem();         
        }
        else if(isTaked && Input.GetKey(KeyCode.E))
        {
            pickable.SetActive(true);
            isTaked = false;
            TakeItem();
        }
    }
    public void TakeItem()
    {
        foreach(Object itemHold in itemsToHold)
        {
            if(isTaked)
            {
                itemHold.item.SetActive(true);
            }
            else
            {
                itemHold.item.SetActive(false);
            }
        }
    }*/
    public void TakeHamburger()
    {
        if(isHand == false)
        {
            hamburger.SetActive(true);
            isBurger = true;
            _foodsPopup.SetActive(false);
            throwButton.SetActive(true);
            garbageButton.SetActive(true);
            isHand = true;
        }
       
    }
    public void TakeDinner()
    {
        if(isHand == false)
        {
            dinner.SetActive(true);
            isDinner = true;
            _foodsPopup.SetActive(false);
            throwButton.SetActive(true);
            garbageButton.SetActive(true);
            isHand = true;  
        }
        
    }
    public void TakeCarrot()
    {
        if (isHand == false)
        {
            carrot.SetActive(true);
            isCarrot = true;
            _foodsPopup.SetActive(false);
            throwButton.SetActive(true);
            garbageButton.SetActive(true);
            isHand = true;   
        }
        
    }
    public void TakeCheese()
    {
        if (isHand == false)
        {
            cheese.SetActive(true);
            isCheese = true;
            _foodsPopup.SetActive(false);
            throwButton.SetActive(true);
            garbageButton.SetActive(true);
            isHand = true;  
        }
        
    }
    public void ThrowFoods()
    {
        if (isBurger)
        {
            if (isFull == false)
            {
                hamburger.SetActive(false);
                TableBurger.SetActive(true);
                isFull = true;
                isHand = false;
            }
        }
        else if (isDinner)
        {
            if (isFull == false)
            {
                dinner.SetActive(false);
                TableDinner.SetActive(true);
                isFull = true;
                isHand = false;
            }
           
        }
        else if (isCarrot)
        {
            if (isFull == false)
            {
                carrot.SetActive(false);
                TableCarrot.SetActive(true);
                isFull = true;
                isHand = false;
            }
           
        }
        else if (isCheese)
        {
            if (isFull == false)
            {
                cheese.SetActive(false);
                TableCheese.SetActive(true);
                isFull = true;
                isHand = false;
            }
            
        }
        else
            return;
    }
    public void Garbage()
    {
        isGarbage = true;
        isHand = false;
        isFull = false; 
        hamburger.SetActive(false);
        dinner.SetActive(false);
        carrot.SetActive(false);
        cheese.SetActive(false);
        TableBurger.SetActive(false);
        TableDinner.SetActive(false);
        TableCarrot.SetActive(false);
        TableCheese.SetActive(false);
    }



}
