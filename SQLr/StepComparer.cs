﻿// --------------------------------------------------------------------------------------------------------------------
// SQLr - SQLr - StepComparer.cs
// <Author></Author>
// <CreatedDate>2016-09-27</CreatedDate>
// <LastEditDate>2016-10-01</LastEditDate>
// <summary>
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace SQLr
{
    #region using

    using System.Collections.Generic;
    using SQLr.ProcessStep;

    #endregion

    public class StepComparer : IEqualityComparer<IProcessStep>
    {
        public bool Equals(IProcessStep one, IProcessStep two)
        {
            return (one.Ordinal == two.Ordinal) && (one.Name == two.Name);
        }

        public int GetHashCode(IProcessStep item) { return (item.Name + item.Ordinal).GetHashCode(); }
    }
}