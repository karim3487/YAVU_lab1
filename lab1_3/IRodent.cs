using System.Runtime.InteropServices;

namespace lab1_3
{
    public interface IRodent : INameClass
    {
        string Name { get; set; }
        string Sex { get; set; }
        float Weight { get; set; }
        string Kind { get; set; }
        int Age { get; set; }
        
        public void Scratch();
    }
}