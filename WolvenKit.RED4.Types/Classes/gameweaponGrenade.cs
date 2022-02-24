using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponGrenade : gameItemObject
	{
		[Ordinal(38)] 
		[RED("lastHitNormal")] 
		public Vector4 LastHitNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(39)] 
		[RED("deliveryMethod")] 
		public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod
		{
			get => GetPropertyValue<CEnum<gamedataGrenadeDeliveryMethodType>>();
			set => SetPropertyValue<CEnum<gamedataGrenadeDeliveryMethodType>>(value);
		}

		public gameweaponGrenade()
		{
			LastHitNormal = new();
		}
	}
}
