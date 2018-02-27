using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DamageAllOpponentCreatures : SpellEffect {

    public override void ActivateEffect(int specialAmount = 0, ICharacter target = null)
    {
		List<CreatureLogic> CreaturesToDamage = new List<CreatureLogic>();

		foreach (Table table in TurnManager.Instance.whoseTurn.otherPlayer.tables) {
			CreaturesToDamage.AddRange (table.CreaturesOnTable);
		}

        foreach (CreatureLogic cl in CreaturesToDamage)
        {
            new DealDamageCommand(cl.ID, specialAmount, healthAfter: cl.Health - specialAmount).AddToQueue();
            cl.Health -= specialAmount;
        }
    }
}
