using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugCompactSpan : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spanData")] 
		public CUInt32 SpanData
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public navgendebugCompactSpan()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
