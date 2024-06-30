using System.Collections.Generic;
using UnityEngine;


public abstract class BehaviourObj : MonoBehaviour
{
    public abstract IEnumerator<YieldInstruction> Run(PlayerController player, Interactable target);
}
