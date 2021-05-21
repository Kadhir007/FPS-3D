using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pool_manager : MonoBehaviour
{
    /*public GameObject bullet_prefab;
    private static pool_manager instance;
    public int bullet_amt = 20;
    private List<GameObject> bullets;
    public static pool_manager Instance { get { return instance; } }
    // Start is called before the first frame update
    void Awake()
    {
        //preload bullets
        bullets = new List<GameObject>(bullet_amt);



        instance = this; 
        for(int i = 0; i < bullet_amt; i++)
        {
            GameObject prefabInstance = Instantiate(bullet_prefab);
            prefabInstance.transform.SetParent(transform);
            prefabInstance.SetActive(false);
        }
        
    } 

    public GameObject getbullet()
    {
        foreach(GameObject bullet in bullets)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                return bullet;
            }    
        }
        GameObject prefabInstance = Instantiate(bullet_prefab);
        prefabInstance.transform.SetParent(transform);
        bullets.Add(prefabInstance);
        return prefabInstance;
    }*/

}
