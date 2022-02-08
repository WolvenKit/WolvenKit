namespace WolvenKit.RED4.Types
{
    public partial class animRig
    {
        [Ordinal(999)]
        [RED("skipRigValidation")]
        public CBool SkipRigValidation
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

    }
}
