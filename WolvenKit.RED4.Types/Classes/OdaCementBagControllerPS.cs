using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OdaCementBagControllerPS : ScriptableDeviceComponentPS
	{
		private CFloat _cementEffectCooldown;

		[Ordinal(104)] 
		[RED("cementEffectCooldown")] 
		public CFloat CementEffectCooldown
		{
			get => GetProperty(ref _cementEffectCooldown);
			set => SetProperty(ref _cementEffectCooldown, value);
		}
	}
}
