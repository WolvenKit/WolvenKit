using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceTriggerRewireMapItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("inputToBeRewiredVariationIndex")] 
		public CUInt32 InputToBeRewiredVariationIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("inputToBeActuallyPlayedName")] 
		public CName InputToBeActuallyPlayedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("inputToBeActuallyPlayedVariationIndex")] 
		public CUInt32 InputToBeActuallyPlayedVariationIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("allowReuse")] 
		public CBool AllowReuse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioVoiceTriggerRewireMapItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
