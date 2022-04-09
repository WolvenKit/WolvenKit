using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameReplAnimTransformRequestBase : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("applyServerTime")] 
		public netTime ApplyServerTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public gameReplAnimTransformRequestBase()
		{
			ApplyServerTime = new() { MilliSecs = 18446744073709551615 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
