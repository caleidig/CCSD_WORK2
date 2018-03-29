using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point2D<T>
    {
        private T m_x;
        private T m_y;

        public Point2D(T x, T y)
        {
            m_x = x;
            m_y = y;
        }

        public override string ToString()
        {
            String s = "(" + m_x + ", " + m_y + ")";
            return s;
        }
        public T X
        {
            get
            {
                //Console.WriteLine("Mult factor (inside of X property ) = " + MultFactor<double>.Instance.GetFactor());
                //Console.WriteLine("x (inside of property) = " + m_x);
                var a1 = m_x as dynamic;
                double a2 = (double)(MultFactor<double>.Instance.GetFactor());
                //Console.WriteLine("a1 = " + a1);
                //Console.WriteLine("a2 = " + a2);
                return ( T )( a1 * a2 );
            }
        }
    }
}
