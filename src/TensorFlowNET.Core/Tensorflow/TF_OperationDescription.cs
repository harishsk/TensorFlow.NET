﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Tensorflow
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TF_OperationDescription
    {
        public IntPtr node_builder;
        //public TF_Graph graph;
    }
}
