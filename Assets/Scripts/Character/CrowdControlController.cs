using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CrowdControlController : IUpdater
{
    List<CrowdControl> container = new List<CrowdControl>();
    List<int> removeIndex = new List<int>();

    public bool isCCed
    {
        get
        {
            return container.Count > 0;
        }
    }

    //TODO: 점감 시스템?

    public void Update()
    {
        for(int i = 0; i < container.Count; i++)
        {
            var c = container[i];
            c.OnStay();
            c.duration -= Time.deltaTime;

            if (c.duration <= 0)
            {
                removeIndex.Add(i);
            }
        }

        for (int i = removeIndex.Count - 1; i >= 0; i--)
        {
            container[i].OnExit();
            container.RemoveAt(i);
        }

        removeIndex.Clear();
    }

    public void ApplyCC(CrowdControl cc)
    {
        cc.currentHandler = this;
        container.Add(cc);
        cc.OnEnter();
    }
}

public abstract class CrowdControl
{
    public CrowdControlController currentHandler;
    
    [System.Flags]
    public enum Type
    {
        Stagger = 1 << 0,
        Knockback = 1 << 1,
    }

    public Type type
    {
        get { return type; }
        protected set { type = value; }
    }

    public float duration;

    public virtual void OnEnter() { }
    public virtual void OnStay() { }
    public virtual void OnExit() { }
}

public class Stagger : CrowdControl
{
    Vector3 dir;

    public Stagger(float duration, Vector3 dir)
    {
        type = Type.Stagger;
        this.duration = duration;
        this.dir = dir;
    }

    public override void OnEnter()
    {

    }

    public override void OnStay()
    {

    }

    public override void OnExit()
    {

    }
}

public class Knockback : CrowdControl
{
    Vector3 dir;
    float distance;

    public Knockback(float duration, Vector3 dir, float distance)
    {
        type = Type.Stagger;
        this.duration = duration;
        this.dir = dir;
        this.distance = distance;
    }

    public override void OnEnter()
    {

    }

    public override void OnStay()
    {

    }

    public override void OnExit()
    {

    }
}