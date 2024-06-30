using System.Collections.Generic;
using UnityEngine;

public class NoneBehaviour : BehaviourObj
{
    public ItemTemplate Template;

    public override IEnumerator<YieldInstruction> Run(PlayerController player, Interactable target)
    {
        yield break;
    }
}
