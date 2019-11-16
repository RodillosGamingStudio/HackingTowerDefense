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

    public GameObject missileLauncherPrefab;

    

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {

        turretToBuild = turret;

    }

}
