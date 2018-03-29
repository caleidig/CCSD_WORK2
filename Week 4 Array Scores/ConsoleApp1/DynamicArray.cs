using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DynamicArray
    {
        private double[] m_array;
        private int m_numValsAdded;
        double minVal;
        int minValLoc;
        double maxVal;
        int maxValLoc;

        public DynamicArray()
        {
            m_array = new double[1];
            m_numValsAdded = 0;
        }
        public int Length
        {
            get
            {
                return m_array.Length;
            }
        }

        protected void ExtendArray( int new_size )
        {
            double[] temp_array = new double[new_size ];

            // backup
            for (int i = 0; i < m_array.Length; i++)
                temp_array[i] = m_array[i];

            // resize
            System.Array.Resize(ref m_array, (m_numValsAdded + 1));

            // restore backup
            for (int i = 0; i < m_array.Length; i++)
                m_array[i] = temp_array[i];
        }

        public void AddToArray(double val)
        {
            m_numValsAdded++;
            if(m_numValsAdded <= m_array.Length)
                m_array[m_numValsAdded - 1] = val;
            else
            {
                ExtendArray(m_numValsAdded + 1);
                m_array[m_numValsAdded - 1] = val;
            }
            
        }

        public double this[int index]
        {
            get
            { 
                 return m_array [index];
             }

            set
            {
                m_array[index] = value;
            }
        }

        public double FindMinVal()
        {

                minVal = m_array[0];
                for (int i = 0; i < m_numValsAdded; i++)
                {
                    if (m_array[i] < minVal)
                    {
                        minVal = m_array[i];
                        minValLoc = i;
                    }
                }
                return minVal;

        }
        public double FindMaxVal()
        {

                maxVal = m_array[0];
                for (int i = 0; i < m_numValsAdded; i++)
                {
                    if (m_array[i] > maxVal)
                    {
                        maxVal = m_array[i];
                        maxValLoc = i;
                    }
                }
                return maxVal;

        }
        public void RemoveValue()
        { }
    }
}
