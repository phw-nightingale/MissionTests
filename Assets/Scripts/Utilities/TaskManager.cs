using System;
using System.Collections.Generic;
using Models;
using UnityEngine;

namespace Utilities
{
    public class TaskManager : MonoSingletonManual<TaskManager>
    {
        public List<Mission> CurrentMissions { get; set; } = new List<Mission>();

        public override void Awake()
        {
            instance = this;
        }
    }
}