using UnityEngine; 
using System.Collections;
namespace Mod
{
    public class Mod
    {
        public static void Main()
        { 
            ModAPI.OnItemSpawned += (sender, obj) =>
            {
                if(obj.Instance.GetComponent<PersonBehaviour>() && !obj.Instance.GetComponent<PersonBehaviour>().Limbs[0].IsAndroid)
                {
                    foreach (var p in obj.Instance.GetComponent<PersonBehaviour>().Limbs)
                    {
                        p.gameObject.AddComponent<BreakLimb>();
                    }
                }
            };
        }
    }
}
//https://discord.gg/ZJaTzsCfGQ (my discord server)