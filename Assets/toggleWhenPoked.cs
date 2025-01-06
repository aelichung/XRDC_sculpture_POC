using System;
using Oculus.Interaction;
using UnityEngine;

public class toggleWhenPoked : MonoBehaviour
{
    public PokeInteractable Interactable;

    public GameObject Item;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnEnable()
    {
        Interactable.WhenInteractorAdded.Action += delegate(PokeInteractor interactor)
        {
            bool isActive = Item.activeSelf;
            Item.SetActive(!isActive);
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
