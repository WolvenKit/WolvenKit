namespace WolvenKit.RED4.Types
{
    public partial class animAnimNode_MathExpressionPose
    {
        [Ordinal(999)]
        [RED("expressionString")]
        public CString ExpressionString
        {
            get => GetPropertyValue<CString>();
            set => SetPropertyValue<CString>(value);
        }
    }
}
