using System.Collections;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject Cube;

    private float _generation_speed = 1;
    private float _cube_speed = 20;
    private float _cube_distance = 50;


    
    void Start()
    {
        StartCoroutine(Gerate());
    }

    private IEnumerator Gerate(){
        GameObject  e = Instantiate(Cube,new Vector3(-25,0.5f,0), Quaternion.identity);

        //Настройка объекта
        e.SendMessage("SetCubeSpeed", _cube_speed);
        e.SendMessage("SetCubeDistance", _cube_distance);

        yield return new WaitForSeconds(_generation_speed);
        StartCoroutine(Gerate());
    }


    //Инпуты
    public void SetGenerationSpeed(string speed){
        _generation_speed = float.Parse(speed);
    }

    public void SetCubeSpeed(string speed){
        _cube_speed = float.Parse(speed);
    }

    public void SetCubeDistance(string distance){
        _cube_distance = float.Parse(distance);
    }


}
