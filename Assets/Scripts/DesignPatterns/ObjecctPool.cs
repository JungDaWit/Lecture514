using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class ObjecctPool
    {
        private Stack<PooledObject> stack;
        private PooledObject targetPrefab;
        private GameObject poolobject;

        private ObjecctPool(PooledObject targetPrefab, int initSize = 5) => Init(targetPrefab, initSize);
        private void Init(PooledObject targetPrefab, int initSize)
        {
            stack = new Stack<PooledObject>(initSize);
            targetPrefab = targetPrefab;
            poolobject = new GameObject($"{targetPrefab.name} Pool");

            for(int i = 0; i < initSize; i++)
            {
                CreatePooledObjeck();
            }
        }
        public PooledObject PopPool()
        {
            if (stack.Count == 0) CreatePooledObjeck();
            PooledObject pooledObject = stack.Pop();
            pooledObject.gameObject.SetActive(true);
            return pooledObject;

        }
        public void PushPool(PooledObject target)
        {
            target.transform.parent = poolobject.transform;
            target.gameObject.SetActive(false);
            stack.Push(target);
        }
        private void CreatePooledObjeck()
        {
            PooledObject obj = MonoBehaviour.Instantiate(targetPrefab);
            obj.PooledInit(this);
            PushPool(obj);
        }
    }
   
}
