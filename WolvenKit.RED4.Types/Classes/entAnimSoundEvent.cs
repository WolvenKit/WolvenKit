using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimSoundEvent : entSoundEvent
	{
		[Ordinal(4)] 
		[RED("metadataContext")] 
		public CName MetadataContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entAnimSoundEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
