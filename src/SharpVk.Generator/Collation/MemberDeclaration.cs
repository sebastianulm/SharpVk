﻿namespace SharpVk.Generator.Collation
{
    public class MemberDeclaration
    {
        public string Name;
        public string ParamName;
        public TypeReference Type;

        public bool RequiresMarshalling => this.Type.PointerType.IsPointer() || this.Type.FixedLength.Type != FixedLengthType.None;
    }
}