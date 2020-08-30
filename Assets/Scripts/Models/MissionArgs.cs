using System;
using UnityEngine;

namespace Models
{
    public class MissionArgs : EventArgs
    {
        public string MissionId { get; set; }
        public string TaskId { get; set; }
        public GameObject Sender { get; set; }
        public int Process { get; set; }

        public override string ToString()
        {
            return $"MissionId: {MissionId}, TaskId: {TaskId}, Sender: {Sender.name}, Process: {Process}";
        }
    }
}