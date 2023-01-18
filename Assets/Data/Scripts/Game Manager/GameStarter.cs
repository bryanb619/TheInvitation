using UnityEngine;

public class GameStarter : MonoBehaviour
{
    float elapsed = 0;
    [SerializeField] private GameObject Handler;


    private void Start()
    {
        Handler.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime; 

        if(elapsed >= 2F)
        {
            Handler.SetActive(true);
        }
        else if(elapsed >= 5f)
        {
            Destroy(this.gameObject);
        }
        
    }
}
