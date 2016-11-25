// ==++==
// 
//   
//    Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//   
//    The use and distribution terms for this software are contained in the file
//    named license.txt, which can be found in the root of this distribution.
//    By using this software in any fashion, you are agreeing to be bound by the
//    terms of this license.
//   
//    You must not remove this notice, or any other, from this software.
//   
// 
// ==--==
////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////
namespace System {
    
    using System;
    
    // Enum used to indicate all the elements of the
    // VOS it is valid to attach this element to.
    [Flags,Serializable]
[System.Runtime.InteropServices.ComVisible(true)]
    public enum AttributeTargets
    {
        Assembly      = 0x0001,
        Module        = 0x0002,
        Class         = 0x0004,
        Struct        = 0x0008,
        Enum          = 0x0010,
        Constructor   = 0x0020,
        Method        = 0x0040,
        Property      = 0x0080,
        Field         = 0x0100,
        Event         = 0x0200,
        Interface     = 0x0400,
        Parameter     = 0x0800,
        Delegate      = 0x1000,
        ReturnValue   = 0x2000,
        GenericParameter = 0x4000,
        
        
        All           = Assembly | Module   | Class | Struct | Enum      | Constructor | 
                        Method   | Property | Field | Event  | Interface | Parameter   | 
                        Delegate | ReturnValue | GenericParameter,
    }
}