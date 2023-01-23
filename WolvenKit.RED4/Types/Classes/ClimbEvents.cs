using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClimbEvents : LocomotionGroundEvents
	{
		[Ordinal(6)] 
		[RED("ikHandEvents")] 
		public CArray<CHandle<entIKTargetAddEvent>> IkHandEvents
		{
			get => GetPropertyValue<CArray<CHandle<entIKTargetAddEvent>>>();
			set => SetPropertyValue<CArray<CHandle<entIKTargetAddEvent>>>(value);
		}

		[Ordinal(7)] 
		[RED("shouldIkHands")] 
		public CBool ShouldIkHands
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("framesDelayingAnimStart")] 
		public CInt32 FramesDelayingAnimStart
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("climbedEntity")] 
		public CWeakHandle<entEntity> ClimbedEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(10)] 
		[RED("playerCapsuleDimensions")] 
		public Vector4 PlayerCapsuleDimensions
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public ClimbEvents()
		{
			IkHandEvents = new();
			PlayerCapsuleDimensions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
