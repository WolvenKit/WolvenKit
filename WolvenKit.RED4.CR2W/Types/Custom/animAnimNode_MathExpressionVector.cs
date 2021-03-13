using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_MathExpressionVector : animAnimNode_MathExpressionVector_
    {
        [Ordinal(999)] [RED("expressionString")] public CString expressionString { get; set; }

        public animAnimNode_MathExpressionVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
