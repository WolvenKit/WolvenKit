using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClimbEvents : LocomotionGroundEvents
	{
		[Ordinal(3)] 
		[RED("ikHandEvents")] 
		public CArray<CHandle<entIKTargetAddEvent>> IkHandEvents
		{
			get => GetPropertyValue<CArray<CHandle<entIKTargetAddEvent>>>();
			set => SetPropertyValue<CArray<CHandle<entIKTargetAddEvent>>>(value);
		}

		[Ordinal(4)] 
		[RED("shouldIkHands")] 
		public CBool ShouldIkHands
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("framesDelayingAnimStart")] 
		public CInt32 FramesDelayingAnimStart
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ClimbEvents()
		{
			IkHandEvents = new();
		}
	}
}
