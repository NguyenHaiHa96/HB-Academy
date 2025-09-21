using System.Collections.Generic;
using UnityEngine;

namespace BridgeRace
{
    public class Character : ColorObject
    {
        [SerializeField] private LayerMask groundLayer;
        [SerializeField] private LayerMask stairLayer;
        [SerializeField] protected Transform skin;
        
        private List<CharacterBrick> _characterBricks = new();
        
        public Vector3 CheckGround(Vector3 nextPoint)
        {
            if (Physics.Raycast(nextPoint, Vector3.down, out var hit, 2f, groundLayer))
            {
                return hit.point + Vector3.up * 1.1f;
            }

            return transform.position;
        }
        
        public bool CanMove(Vector3 nextPoint)
        {
            bool isCanMove = true;

            if (Physics.Raycast(nextPoint, Vector3.down, out var hit, 2f, stairLayer))
            {
                Stair stair = Cache.GetStair(hit.collider);

                if (stair.colorType != colorType && _characterBricks.Count > 0)
                {
                    stair.ChangeColor(colorType);
                    // RemoveBrick();
                    // stage.NewBrick(colorType);
                }

                if (stair.colorType != colorType && _characterBricks.Count == 0 && skin.forward.z > 0)
                {
                    isCanMove = false;
                }
            }

            return isCanMove;
        }
    }
}