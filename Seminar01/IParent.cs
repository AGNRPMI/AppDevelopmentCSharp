using System;
namespace Seminar01
{
    public interface IParent
    {
        public bool GetChildren(out Person[] children);
        public void TakeCare();
    }
}