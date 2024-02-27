using System;

namespace DefaultNamespace
{
    public sealed class Hoge
    {
        public int Add(int a , int b)
        {
            
            return a + b;
        }
        
        /// <summary>
        /// 強制的にExceptionを実行する
        /// </summary>
        public void ForceException()
        {
            throw new Exception();
        }
    }
}