using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPlayerController : ICharacterController {

    ControllerData ICharacterController.Controll(){

        ControllerData cd = new ControllerData();

        if (Input.GetKey(KeyCode.LeftArrow)){
            cd.isLeft = true;
        }

        if (Input.GetKey(KeyCode.RightArrow)){
            cd.isRight = true;
        }

        if (Input.GetKey(KeyCode.DownArrow)){
            cd.isDown = true;
        }

        if (Input.GetKey(KeyCode.UpArrow)){
            cd.isUp = true;
        }

        return cd;
    }
}
