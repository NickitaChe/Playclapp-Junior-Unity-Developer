using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private float _speed;
    private float _distance;
    private CharacterController controller;

    private Vector3 startPosition;

    void Start(){
        startPosition = gameObject.transform.position;
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        //Проверка на пройденное растояние
        if(gameObject.transform.position.x - startPosition.x >= _distance){
            Destroy(gameObject);
        }
        
        //Движение
        var move = new Vector3(1,0,0); //Направление
        controller.Move(move*_speed*Time.deltaTime);
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
    public void SetCubeSpeed(float speed){
        _speed = speed;
    }

    public void SetCubeDistance(float distance){
        _distance = distance;
    }
}
