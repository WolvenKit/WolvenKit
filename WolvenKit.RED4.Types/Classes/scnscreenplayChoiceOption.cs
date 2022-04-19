using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnscreenplayChoiceOption : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get => GetPropertyValue<scnscreenplayItemId>();
			set => SetPropertyValue<scnscreenplayItemId>(value);
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public scnscreenplayOptionUsage Usage
		{
			get => GetPropertyValue<scnscreenplayOptionUsage>();
			set => SetPropertyValue<scnscreenplayOptionUsage>(value);
		}

		[Ordinal(2)] 
		[RED("locstringId")] 
		public scnlocLocstringId LocstringId
		{
			get => GetPropertyValue<scnlocLocstringId>();
			set => SetPropertyValue<scnlocLocstringId>(value);
		}

		public scnscreenplayChoiceOption()
		{
			ItemId = new() { Id = 4294967040 };
			Usage = new() { PlayerGenderMask = new() { Mask = 128 } };
			LocstringId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
