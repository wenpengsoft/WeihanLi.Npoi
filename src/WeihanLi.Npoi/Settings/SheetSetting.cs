﻿namespace WeihanLi.Npoi.Settings
{
    internal class SheetSetting
    {
        /// <summary>
        /// SheetIndex
        /// </summary>
        internal int SheetIndex { get; set; } = 0;

        /// <summary>
        /// SheetName
        /// </summary>
        internal string SheetName { get; set; }

        /// <summary>
        /// StartRowIndex
        /// </summary>
        internal int StartRowIndex { get; set; } = 1;

        /// <summary>
        /// HeaderRowIndex
        /// </summary>
        internal int HeaderRowIndex => StartRowIndex - 1;
    }
}