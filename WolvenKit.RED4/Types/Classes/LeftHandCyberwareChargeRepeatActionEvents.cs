using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LeftHandCyberwareChargeRepeatActionEvents : LeftHandCyberwareActionAbstractEvents
	{
		[Ordinal(3)] 
		[RED("maxSpread")] 
		public CFloat MaxSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxProjectiles")] 
		public CInt32 MaxProjectiles
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public LeftHandCyberwareChargeRepeatActionEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
