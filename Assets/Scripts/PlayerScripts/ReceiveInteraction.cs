using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveInteraction : Subject
{
    bool isInteractable;
    public static event Action<WeaponUpgradeDefinition> OnWeaponUpgradePickedUp;

    private void Start()
    {
        isInteractable = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (isInteractable)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("ReceiveInteractable"))
            {
                //Debug.Log("Contacted with an Interactable");
                ICircle circle = null;
                if (other.gameObject.TryGetComponent(out ICircle getCircle))
                {
                    circle = getCircle;
                    //Debug.Log("Contacted with ICircle");
                }

                if (other.gameObject.TryGetComponent(out IDistanceBasedCircle getSpecialCircle))
                {
                    //Debug.Log("Contacted with IDistanceBasedCircle");
                    ICircle adapter = new SpecialToRegularCircleAdapter(this.gameObject.transform.position, getSpecialCircle.Type, getSpecialCircle.Amount, getSpecialCircle);
                    circle = adapter;             
                }

                if (circle != null)
                {
                    NotifyObservers(circle.Type, circle.GetCalculatedAmount());
                    isInteractable = false;
                    StartCoroutine(ReceiveInteractCooldown());
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("AutoPickupable"))
        {
            if (other.gameObject.TryGetComponent(out IAutoPickupable pickupableItem))
            {
                Debug.LogWarning(pickupableItem.GetSettings().type);
                

                if (other.gameObject.TryGetComponent(out WeaponUpgradePickupable controller))
                {
                    OnWeaponUpgradePickedUp?.Invoke(controller.weaponUpgradeDefinition);
                }
                else
                {
                    NotifyObservers(pickupableItem.GetSettings().statType, pickupableItem.GetSettings().statEffectAmount);
                }
                


                pickupableItem.PickupThis();
            }
        }
        

    }

    IEnumerator ReceiveInteractCooldown()
    {
        yield return new WaitForSeconds(1);
        isInteractable = true;
    }
}
