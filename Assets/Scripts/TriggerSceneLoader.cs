using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSceneLoader : MonoBehaviour
{
    [SerializeField, TagField] private string loadingActivatorTag;
    [SerializeField] private int sceneBuildIndex;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(loadingActivatorTag))
            SceneManager.LoadScene(sceneBuildIndex);
    }
}
