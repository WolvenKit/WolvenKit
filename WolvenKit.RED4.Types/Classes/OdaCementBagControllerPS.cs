using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OdaCementBagControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("cementEffectCooldown")] 
		public CFloat CementEffectCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public OdaCementBagControllerPS()
		{
			DeviceName = "LocKey#17265";
			TweakDBRecord = new() { Value = 102153496184 };
			TweakDBDescriptionRecord = new() { Value = 153526934731 };
		}
	}
}
