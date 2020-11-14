using System;
using System.Collections;
using System.Collections.Generic;
using GameFramework.Event;
using UnityEngine;

public class BirdDeadEventArgs : GameEventArgs
{
    public static readonly int EventId = typeof(BirdDeadEventArgs).GetHashCode();

    public override int Id
    {
        get { return EventId; }
    }

    public override void Clear()
    {
        
    }
}
