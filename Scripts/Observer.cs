using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer
{
    public abstract void OnNotify();
}

public class DonkeyKong : Observer
{
    GameObject cubeObj;
    donkeyEditorEvents donkeyEvent;

    public DonkeyKong(GameObject cubeObj, donkeyEditorEvents donkeyEvent)
    {
        this.cubeObj = cubeObj;
        this.donkeyEvent = donkeyEvent;
    }

    public override void OnNotify()
    {
        cubeColor(donkeyEvent.cubeEditorColor());
    }

    void cubeColor(Color mat)
    {
        if (cubeObj)
        {
            cubeObj.GetComponent<Renderer>().materials[0].color = mat;
        }
    }
}
