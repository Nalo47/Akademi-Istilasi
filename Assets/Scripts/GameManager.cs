using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool bittimi;
    public GameObject teleport;

    void Update()
    {
        if (düsmanhasaralma.dusmansayısı == 0)
        {
            teleport.SetActive(true);
        }
    }
}
