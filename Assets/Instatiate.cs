using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Instatiate : MonoBehaviour
{
    [SerializeField] private GameObject PlayerPrefab = null;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(Random.Range(-4.0f, 4.0f), 2f, 0), Quaternion.identity);
    }

}