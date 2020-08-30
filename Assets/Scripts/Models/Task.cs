using UnityEngine;
using Utilities;

namespace Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Task
    {
        
        public string Id { get; set; }
        public int NowProcess { get; set; } = 0;
        public int TargetProcess { get; set; }
        public bool IsFinish { get; set; } = false;
        public string Description { get; set; }
        
    }
}