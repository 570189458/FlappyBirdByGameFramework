using System;
using System.Collections;
using System.Collections.Generic;
using FlappyBird;
using GameFramework;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;
using GameEntry = FlappyBird.GameEntry;

public class GameOverForm : UGuiForm
{
    public Text Score;

    protected override void OnOpen(object userData)
    {
        base.OnOpen(userData);

        int score = GameEntry.DataNode.GetNode("Score").GetData<VarInt>();
        Score.text = "你的总分" + score;
    }

    protected override void OnClose(object userData)
    {
        base.OnClose(userData);
        Score.text = String.Empty;
    }

    public void OnRestartButtonClick()
    {
        Close(true);
        GameEntry.Event.Fire(this, ReferencePool.Acquire<RestartEventArgs>());
        
        GameEntry.Entity.ShowBird(new BirdData(GameEntry.Entity.GenerateSerialId(), 3, 5f));
    }

    public void OnReturnButtonClick()
    {
        Close(true);
        GameEntry.Event.Fire(this, ReferencePool.Acquire<ReturnMenuEventArgs>());
    }
}
