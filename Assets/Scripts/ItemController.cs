using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    [SerializeField] private GameObject _foodsPopup;
    public Animator animator;
    public Transform chairTarget;
    public Transform bedTarget;
    private void Awake()
    {
        animator = GetComponent<Animator>();    
    }
    public void SitOnChair()
    {
        transform.position = chairTarget.position;
        transform.rotation = chairTarget.rotation;

        animator.SetTrigger("Sit");
    }
    public void Telephone()
    {
        animator.SetTrigger("TalkPhone");
    }
    public void Dance()
    {
        animator.SetTrigger("Dance");
    }
    public void Boxing()
    {
        animator.SetTrigger("Boxing");
    }
    public void Bed()
    {
        transform.position = bedTarget.position;
        transform.rotation = bedTarget.rotation;

        animator.SetTrigger("Sleep");
    }
    public void Fridge()
    {
        _foodsPopup.SetActive(true);
    }
    public void CloseFoods()
    {
        _foodsPopup.SetActive(false);
    }


}
