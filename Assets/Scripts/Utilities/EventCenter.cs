using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace Utilities
{
    
    public class EventCenter : MonoSingletonAuto<EventCenter>
    {
        private Dictionary<string, UnityAction<EventArgs>> center = new Dictionary<string, UnityAction<EventArgs>>();

        public void Subscribe(string title, UnityAction<EventArgs> action)
        {
            if (center.ContainsKey(title))
            {
                center[title] += action;
            }
            else
            {
                center.Add(title, action);
            }
        }

        public void Cancel(string title, UnityAction<EventArgs> action)
        {
            if (center.ContainsKey(title))
            {
                center[title] -= action;
            }
        }

        public void Clear(string title)
        {
            if (center.TryGetValue(title, out var events))
            {
                events = null;
            }
        }

        public void Trigger(string title, EventArgs args)
        {
            if (center.TryGetValue(title, out var events))
            {
                events?.Invoke(args);
            }
        }
    }

}