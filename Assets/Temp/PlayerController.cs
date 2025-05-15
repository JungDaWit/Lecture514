using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Test
{
    public class PlayerController : MonoBehaviour
    {
        public PlayerMovement movement;
        public PlayerStatus status;

        private void Update()
        {
            MoveTest();

            status.IsAiming.Value = Input.GetKey(KeyCode.Mouse1);
        }
        public void MoveTest()
        {
            // (회전 수행 후)좌우회전에 대한 백터 반환
            Vector3 camRotatedir = movement.SetAimRotation();

            float moveSpeed;
            if (status.IsAiming.Value) moveSpeed = status.WalkSpeed;
            else moveSpeed = status.RunSpeed;

            Vector3 moveDir =  movement.SetMove(moveSpeed);
            status.IsMoving.Value = (moveDir != Vector3.zero);

            Vector3 avatarDir;
            if (status.IsAiming.Value) avatarDir = camRotatedir;
            else avatarDir = moveDir;

           // movement.SetAvtarRotation(avatarDir);

        }
        private void s()
        {
            
        }
        private void HandleMoverment()
        {

        }
        private void HandleAiming()
        {
           // status.IsAiming.Value = Input.GetKey(aimKey);
        }
        
    }
}
