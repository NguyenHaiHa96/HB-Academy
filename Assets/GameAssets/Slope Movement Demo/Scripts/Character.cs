using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlopeMovementDemo
{
    public class Character : MonoBehaviour
    {
        public bool CanMove(Vector3 nextPoint)
        {
            //check mau stair
            //k cung mau -> fill
            //het gach + k cung mau + huong di len

            bool isCanMove = true;
            RaycastHit hit;

            // if (Physics.Raycast(nextPoint, Vector3.down, out hit, 2f, stairLayer))
            // {
            //     Stair stair = hit.collider.GetComponent<Stair>();
            //
            //     if (stair.colorType != colorType && playerBricks.Count > 0)
            //     {
            //         stair.ChangeColor(colorType);
            //         RemoveBrick();
            //         stage.NewBrick(colorType);
            //     }
            //
            //     // if (stair.colorType != colorType && playerBricks.Count == 0 && skin.forward.z > 0)
            //     // {
            //     //     isCanMove = false;
            //     // }
            // }

            return isCanMove;
        }
    }
    
    // public Vector3 CheckGround(Vector3 nextPoint)
    // {
    //     RaycastHit hit;
    //
    //     if (Physics.Raycast(nextPoint, Vector3.down, out hit, 2f, groundLayer))
    //     {
    //         return hit.point + Vector3.up * 1.1f;
    //     }
    //
    //     return TF.position;
    // }
}
