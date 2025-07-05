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
		[RED("deadEyeWidget")] 
		public inkWidgetReference DeadEyeWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public gamesmartGunUITargetParameters Data
		{
			get => GetPropertyValue<gamesmartGunUITargetParameters>();
			set => SetPropertyValue<gamesmartGunUITargetParameters>(value);
		}

		[Ordinal(5)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("unlockingAnimationProxy")] 
		public CHandle<inkanimProxy> UnlockingAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(7)] 
		[RED("activeCallbacks")] 
		public CArray<gameDelayID> ActiveCallbacks
		{
			get => GetPropertyValue<CArray<gameDelayID>>();
			set => SetPropertyValue<CArray<gameDelayID>>(value);
		}

		[Ordinal(8)] 
		[RED("hasDeadEye")] 
		public CBool HasDeadEye
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("deadEyeAnimProxy")] 
		public CHandle<inkanimProxy> DeadEyeAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public Crosshair_Smart_Rifl_Bucket()
		{
			LockingAnimationLength = 1.000000F;
			UnlockingAnimationLength = 1.000000F;
			DeadEyeWidget = new inkWidgetReference();
			Data = new gamesmartGunUITargetParameters { Pos = new Vector2(), EntityID = new entEntityID() };
			ActiveCallbacks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
