using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedeviceClearance : IScriptable
	{
		[Ordinal(0)] 
		[RED("min")] 
		public CInt32 Min
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CInt32 Max
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gamedeviceClearance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
