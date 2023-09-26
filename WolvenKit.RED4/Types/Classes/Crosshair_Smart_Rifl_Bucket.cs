using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Crosshair_Smart_Rifl_Bucket : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("lockingAnimationLength")] 
		public CFloat LockingAnimationLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("unlockingAnimationLength")] 
		public CFloat UnlockingAnimationLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public gamesmartGunUITargetParameters Data
		{
			get => GetPropertyValue<gamesmartGunUITargetParameters>();
			set => SetPropertyValue<gamesmartGunUITargetParameters>(value);
		}

		[Ordinal(4)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(5)] 
		[RED("unlockingAnimationProxy")] 
		public CHandle<inkanimProxy> UnlockingAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("activeCallbacks")] 
		public CArray<gameDelayID> ActiveCallbacks
		{
			get => GetPropertyValue<CArray<gameDelayID>>();
			set => SetPropertyValue<CArray<gameDelayID>>(value);
		}

		public Crosshair_Smart_Rifl_Bucket()
		{
			LockingAnimationLength = 1.000000F;
			UnlockingAnimationLength = 1.000000F;
			Data = new gamesmartGunUITargetParameters { Pos = new Vector2(), EntityID = new entEntityID() };
			ActiveCallbacks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
