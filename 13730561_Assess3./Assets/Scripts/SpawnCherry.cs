using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCherry : MonoBehaviour
{

    public GameObject BlueberryPrefab;
    public float respawntime = 10.0f;
    private Vector2 screenBounds;




    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(BerryTimer());
    }

    private void SpawnBlueberry()
    {
        GameObject B = Instantiate(BlueberryPrefab) as GameObject;
        B.transform.position = new Vector2(screenBounds.x * 1.2f, Random.Range(-screenBounds.y, screenBounds.y));
        Destroy(this.gameObject);
    }

    IEnumerator BerryTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawntime);
          SpawnBlueberry();
        }
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
