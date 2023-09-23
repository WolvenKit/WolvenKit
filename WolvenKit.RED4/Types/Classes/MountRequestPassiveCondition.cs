using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MountRequestPassiveCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)] 
		[RED("unmountRequest")] 
		public CBool UnmountRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("acceptInstant")] 
		public CBool AcceptInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("acceptNotInstant")] 
		public CBool AcceptNotInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("acceptForcedTransition")] 
		public CBool AcceptForcedTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("succeedOnMissingMountedEntity")] 
		public CBool SucceedOnMissingMountedEntity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("highLevelStateCallbackId")] 
		public CUInt32 HighLevelStateCallbackId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public MountRequestPassiveCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
