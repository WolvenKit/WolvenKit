using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedInputSetterBase : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("applyServerTime")] 
		public netTime ApplyServerTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public entReplicatedInputSetterBase()
		{
			ApplyServerTime = new netTime { MilliSecs = long.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
