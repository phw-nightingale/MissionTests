using System.Collections.Generic;

namespace Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Mission
    {
        public string Id { get; set; }
        public string Scene { get; set; }
        public string Role { get; set; }
        
        public List<Task> Tasks { get; set; } = new List<Task>();
        
        
    }
}