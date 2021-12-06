using UnityEngine;
using System.Collections;
namespace Mod
{
    public class BreakLimb : MonoBehaviour 
    { 
        void Shot(Shot shot)
        {
            if (UnityEngine.Random.Range(0f, 650f) < shot.damage)
            {
                this.gameObject.GetComponent<LimbBehaviour>().BreakBone();
            }
        }
    }
}