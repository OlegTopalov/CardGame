using UnityEngine;
using System.Collections;
using DG.Tweening;

public class DragHeroPowerActions : DraggingActions {

    public TargetingOptions Options;

    public override void OnStartDrag()
    {
       
    }

    public override void OnDraggingInUpdate()
    {

    }

    public override void OnEndDrag()
    {

        // 1) Check if we are holding a card over the table
        if (DragSuccessful())
        {
            
        }
        else
        {
            
        } 
    }

    protected override bool DragSuccessful()
    {

		int index = TableVisual.CursorOverTable;

		bool TableNotFull = true;
		if(index!=-1)
			TableNotFull = (playerOwner.tables[index].CreaturesOnTable.Count < 4);

        return TableVisual.CursorOverSomeTable&& TableNotFull;
    }
}
