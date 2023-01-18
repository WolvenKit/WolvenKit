namespace WolvenKit.RED4.Types
{
    public partial class gameJournalInternetPage
    {
        [Ordinal(3)]
        [RED("activatedAtStart")]
        public CBool ActivatedAtStart
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
