using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public GameObject CubeOriginal;
    [SerializeField] private int NbCube;
    [SerializeField] private float Rayon;
    [SerializeField] private float CentreX;
    [SerializeField] private float CentreY;
    public LineRenderer CercleRenderer;// Start is called before the first frame update
    void Start()
    {
        DessinerCercle(100,Rayon);
        CreateCubes(NbCube);
        
    }

    void CreateCubes(int CubeNum){
        for (int i=0;i< CubeNum;i++){
            float angle=2*Mathf.PI*i/CubeNum;
            GameObject CubeClone = Instantiate(CubeOriginal, new Vector3(CentreX + Rayon*Mathf.Cos(angle),CentreY + Rayon*Mathf.Sin(angle),0),CubeOriginal.transform.rotation);
            
        }
    }

    void DessinerCercle(int intervalle, float valRayon){
        CercleRenderer.positionCount=intervalle;
        for(int i=0;i<intervalle;i++){
            float angle=2*Mathf.PI*i/intervalle;
            float x=valRayon*Mathf.Cos(angle);
            float y=valRayon*Mathf.Sin(angle);
            Vector3 PosActuel=new Vector3(CentreX+x,CentreY+y,0);
            CercleRenderer.SetPosition(i,PosActuel);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
