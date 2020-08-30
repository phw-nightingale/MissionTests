using UnityEngine;
using System.Collections;
using System;
using Utilities;

public class MesManager : MonoSingletonAuto<MesManager> {

    public event EventHandler<TaskEventArgs> checkEvent;

    public void Check(TaskEventArgs e)
    {
        checkEvent(this,e);
    }
}
