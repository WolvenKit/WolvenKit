using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BraindanceClueData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<ClueState> State
		{
			get => GetPropertyValue<CEnum<ClueState>>();
			set => SetPropertyValue<CEnum<ClueState>>(value);
		}

		[Ordinal(4)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get => GetPropertyValue<CEnum<gameuiEBraindanceLayer>>();
			set => SetPropertyValue<CEnum<gameuiEBraindanceLayer>>(value);
		}

		public BraindanceClueData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
