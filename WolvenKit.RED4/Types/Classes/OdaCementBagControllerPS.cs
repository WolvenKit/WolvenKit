using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OdaCementBagControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("cementEffectCooldown")] 
		public CFloat CementEffectCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public OdaCementBagControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
