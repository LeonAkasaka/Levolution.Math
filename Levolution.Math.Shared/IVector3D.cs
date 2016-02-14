using System;
using System.Collections.Generic;
using System.Text;

namespace System.Math
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IVector3D<T>
    {
        /// <summary>
        /// 
        /// </summary>
        T X { get; }

        /// <summary>
        /// 
        /// </summary>
        T Y { get; }

        /// <summary>
        /// 
        /// </summary>
        T Z { get; }             
    }
}
