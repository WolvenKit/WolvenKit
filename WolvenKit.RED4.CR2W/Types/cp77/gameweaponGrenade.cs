using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponGrenade : gameItemObject
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

		public gameweaponGrenade(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
