using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponGrenade : gameItemObject
	{
		private Vector4 _lastHitNormal;
		private CEnum<gamedataGrenadeDeliveryMethodType> _deliveryMethod;

		[Ordinal(43)] 
		[RED("lastHitNormal")] 
		public Vector4 LastHitNormal
		{
			get => GetProperty(ref _lastHitNormal);
			set => SetProperty(ref _lastHitNormal, value);
		}

		[Ordinal(44)] 
		[RED("deliveryMethod")] 
		public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod
		{
			get => GetProperty(ref _deliveryMethod);
			set => SetProperty(ref _deliveryMethod, value);
		}
	}
}
