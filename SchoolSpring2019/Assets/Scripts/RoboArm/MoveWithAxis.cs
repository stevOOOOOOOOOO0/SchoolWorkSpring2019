﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithAxis : MoveBase {
    public override void Move(CharacterController controller)
    {
        if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
        {
            position.y = Input.GetAxis("vertical") * Speed * Time.deltaTime;
        }
        else
        {
            position.y = Gravity * Time.deltaTime;
        }

        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        controller.Move(position);
    }
}
