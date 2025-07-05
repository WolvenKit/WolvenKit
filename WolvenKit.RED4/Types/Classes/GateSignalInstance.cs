using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GateSignalInstance : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("gateSignal")] 
		public CHandle<GateSignal> GateSignal
		{
			get => GetPropertyValue<CHandle<GateSignal>>();
			set => SetPropertyValue<CHandle<GateSignal>>(value);
		}

		[Ordinal(1)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("consumeTags")] 
		public CArray<CName> ConsumeTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public GateSignalInstance()
		{
			ConsumeTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
