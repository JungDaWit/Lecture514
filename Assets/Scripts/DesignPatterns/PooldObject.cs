using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public abstract class PooledObject : MonoBehaviour
    {
        public ObjecctPool ObjPool { get; private set; }
        public void PooledInit(ObjecctPool objPool)
        {
            ObjPool = objPool;
        }
        public void ReturnPool()
        {
            ObjPool.PushPool(this);
        }
    }
}
