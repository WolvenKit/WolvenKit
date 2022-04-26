using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiHUDVideoStopEvent : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("videoPathHash")] 
		public CUInt64 VideoPathHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("isSkip")] 
		public CBool IsSkip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiHUDVideoStopEvent()
		{
			IsSkip = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
