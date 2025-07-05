using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class effectTrackItem : effectBaseItem
	{
		[Ordinal(0)] 
		[RED("timeBegin")] 
		public CFloat TimeBegin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("timeDuration")] 
		public CFloat TimeDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		public effectTrackItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
