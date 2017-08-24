using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnemyController : ICharacterController{

    ControllerData ICharacterController.Controll(){

        return new ControllerData();
    }
}
