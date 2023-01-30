namespace WolvenKit.ViewModels.Documents
{
    public interface IBindable
    {
        public SeparateMatrix Matrix { get; set; }
        public string? BindName { get; set; }
        public string? SlotName { get; set; }
    }
}
