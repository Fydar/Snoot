using System.Collections.Generic;
using UnityEngine;

public class SquizPepTalk : BehaviourObj
{
    public override IEnumerator<YieldInstruction> Run(PlayerController player, Interactable target)
    {
        transform.position = player.DropPoint.position;

        yield break;
    }
}
