using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workTagNode : workIEntry
	{
		[Ordinal(2)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public workTagNode()
		{
			Id = new workWorkEntryId { Id = uint.MaxValue };
			Flags = 128;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
