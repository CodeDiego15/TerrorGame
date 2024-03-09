using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Logica_Red : MonoBehaviourPunCallbacks
{
    public static Logica_Red instancia;

    void Awake()
    {
        instancia = this;
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Felicidades! Estas conectado");
    }
}
