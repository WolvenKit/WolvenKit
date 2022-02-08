namespace WolvenKit.RED4.Types
{
    public partial class gameJournalCodexDescription
    {
        [Ordinal(999)]
        [RED("activatedAtStart")]
        public CBool ActivatedAtStart
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
