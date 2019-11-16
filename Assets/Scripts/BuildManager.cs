using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Mas de un BuilgManager en la escena");
            return;
        }
        instance = this;
    }

    public GameObject standarTurretPrefab;

    void Start()
    {

        turretToBuild = standarTurretPrefab;
        
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
