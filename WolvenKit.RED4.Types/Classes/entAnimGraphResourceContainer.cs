using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimGraphResourceContainer : entIComponent
	{
		[Ordinal(3)] 
		[RED("animGraphLookupTable")] 
		public CArray<entAnimGraphResourceContainerEntry> AnimGraphLookupTable
		{
			get => GetPropertyValue<CArray<entAnimGraphResourceContainerEntry>>();
			set => SetPropertyValue<CArray<entAnimGraphResourceContainerEntry>>(value);
		}

		public entAnimGraphResourceContainer()
		{
			Name = "Component";
			AnimGraphLookupTable = new();
		}
	}
}
