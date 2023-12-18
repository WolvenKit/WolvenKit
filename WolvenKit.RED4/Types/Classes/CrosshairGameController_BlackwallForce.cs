using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_BlackwallForce : CrosshairGameController_Smart_Rifl
	{
		[Ordinal(72)] 
		[RED("lastSmartParams")] 
		public CHandle<gamesmartGunUIParameters> LastSmartParams
		{
			get => GetPropertyValue<CHandle<gamesmartGunUIParameters>>();
			set => SetPropertyValue<CHandle<gamesmartGunUIParameters>>(value);
		}

		[Ordinal(73)] 
		[RED("smartGunData")] 
		public CHandle<gamesmartGunUIParameters> SmartGunData
		{
			get => GetPropertyValue<CHandle<gamesmartGunUIParameters>>();
			set => SetPropertyValue<CHandle<gamesmartGunUIParameters>>(value);
		}

		[Ordinal(74)] 
		[RED("targetList")] 
		public CArray<gamesmartGunUITargetParameters> TargetList
		{
			get => GetPropertyValue<CArray<gamesmartGunUITargetParameters>>();
			set => SetPropertyValue<CArray<gamesmartGunUITargetParameters>>(value);
		}

		[Ordinal(75)] 
		[RED("targetData")] 
		public gamesmartGunUITargetParameters TargetData
		{
			get => GetPropertyValue<gamesmartGunUITargetParameters>();
			set => SetPropertyValue<gamesmartGunUITargetParameters>(value);
		}

		[Ordinal(76)] 
		[RED("numOfTargets")] 
		public CInt32 NumOfTargets
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(77)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public CrosshairGameController_BlackwallForce()
		{
			TargetList = new();
			TargetData = new gamesmartGunUITargetParameters { Pos = new Vector2(), EntityID = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
