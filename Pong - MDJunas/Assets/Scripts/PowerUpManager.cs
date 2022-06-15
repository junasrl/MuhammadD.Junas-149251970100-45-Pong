using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public int spawnInterval;
    private float timer;
    public Transform spawnArea;
    public Vector2 powerUpAreaMax;
    public Vector2 powerUpAreaMin;
    public int maxPowerUpAmount;
    public List<GameObject> powerUpTemplateList;
    private List<GameObject> powerUpList;
    // Start is called before the first frame update

    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while(powerUpList.Count>0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }
    public void GenerateRandomPowerUp() 
    { 
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y))); 
    } 
    public void GenerateRandomPowerUp(Vector2 position)
    {
        if (powerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }

        if (position.x < powerUpAreaMin.x ||
            position.x > powerUpAreaMax.x ||
            position.y < powerUpAreaMin.y ||
            position.x > powerUpAreaMax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea); 
        powerUp.SetActive(true);

        powerUpList.Add(powerUp);
    }

    IEnumerator PowerUpTimeOut()
    {
         RemovePowerUp(powerUpList[0]);
         yield return new WaitForSeconds(5);
    }
    private void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > spawnInterval)
        {
            if(powerUpList.Count <= maxPowerUpAmount)
            {
                while(powerUpList.Count == maxPowerUpAmount)
                {
                    StartCoroutine(PowerUpTimeOut());
                }
            }

            GenerateRandomPowerUp();
            timer -= spawnInterval;

        } 
    }
}
