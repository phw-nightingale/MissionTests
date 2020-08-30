using System;
using Models;
using UnityEngine;
using UnityEngine.UI;
using Utilities;
using Task = Models.Task;

namespace Test1
{
    public class TestMission1 : MonoBehaviour
    {
        public Button btn;
        
        private void Start()
        {
            Mission mission = new Mission(); 
            Models.Task task = new Models.Task();
            task.Id = "Mission_1";
            task.Description = "Test1";
            task.TargetProcess = 1;
            mission.Tasks.Add(task);
            Utilities.TaskManager.Instance.CurrentMissions.Add(mission);
            EventCenter.Instance.Subscribe(task.Id, args =>
            {
                Debug.Log(args);
            });
            btn.onClick.AddListener(Test1);
        }

        private void Test1()
        {
            Debug.Log("VAR");
            var args = new MissionArgs();
            args.Sender = gameObject;
            args.Process = 1;
            args.MissionId = "1";
            args.TaskId = "1";
            EventCenter.Instance.Trigger("Mission_1", args);
        }
    }
}