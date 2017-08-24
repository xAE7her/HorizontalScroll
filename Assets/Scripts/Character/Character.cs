using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public enum ControllerType{
        Player,
        Enemy,
    }

    [SerializeField]
    private float movementSpeed;

    [SerializeField]
    private ControllerType controllerType = ControllerType.Player;

    private ICharacterController controller;

    void Start() {
        switch (controllerType) {
            case ControllerType.Player:
                controller = new IPlayerController();
                break;
            case ControllerType.Enemy:
                controller = new IEnemyController();
                break;
        }
    }

	
	void Update () {
        Move();
	}

    private void Move(){
        ControllerData cd = controller.Controll();

        float deltaMovementSpeed = movementSpeed * Time.deltaTime;

        if (cd.isLeft){
            this.transform.Translate(new Vector3(- deltaMovementSpeed, 0, 0));
        }
        if (cd.isRight){
            this.transform.Translate(new Vector3(deltaMovementSpeed, 0, 0));
        }
    }
}
