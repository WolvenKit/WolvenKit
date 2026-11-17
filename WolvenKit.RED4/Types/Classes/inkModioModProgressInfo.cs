using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkModioModProgressInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("modID")] 
		public CInt64 ModID
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(1)] 
		[RED("progressState")] 
		public CEnum<inkModioModProgressState> ProgressState
		{
			get => GetPropertyValue<CEnum<inkModioModProgressState>>();
			set => SetPropertyValue<CEnum<inkModioModProgressState>>(value);
		}

		[Ordinal(2)] 
		[RED("progressRate")] 
		public CFloat ProgressRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkModioModProgressInfo()
		{
			ModID = -1;
			ProgressState = Enums.inkModioModProgressState.MAX;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
