using System.Collections;
using System.Collections.Generic;
using FlappyBird;
using UnityEngine;

/// <summary>
/// 背景实体数据
/// </summary>
public class BgData : EntityData
{
    /// <summary>
    /// 移动速度
    /// </summary>
    public float MoveSpeed { get; private set; }
    
    /// <summary>
    /// 到达次目标时产生新的背景实体
    /// </summary>
    public float SpawnTarget { get; private set; }
    
    /// <summary>
    /// 到达此目标时隐藏自身
    /// </summary>
    public float HideTarget { get; private set; }
    
    /// <summary>
    /// 移动起始点
    /// </summary>
    public float StartPosition { get; private set; }

    public BgData(int entityId, int typeId, float moveSpeed, float startPosition) : base(entityId, typeId)
    {
        MoveSpeed = moveSpeed;
        SpawnTarget = -8f;
        HideTarget = -26.4f;
        StartPosition = startPosition;
    }
}
