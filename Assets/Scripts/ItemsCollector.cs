using Cinemachine;
using UnityEngine;

public class ItemsCollector :  MonoBehaviour
{
    [SerializeField, TagField] private string collectableItemsTag;
    private int _numberOfCollectedItems;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(collectableItemsTag))
        {
            Collect(other.gameObject);
            Debug.Log("Total items collected: " + _numberOfCollectedItems);
        }
    }

    private void Collect(GameObject itemGameObject)
    {
        itemGameObject.SetActive(false);
        _numberOfCollectedItems++;
    }
}
