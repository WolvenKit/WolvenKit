using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_MathExpressionFloat : animAnimNode_MathExpressionFloat_
    {
        [Ordinal(999)] [RED("expressionString")] public CString ExpressionString { get; set; }

        public animAnimNode_MathExpressionFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
