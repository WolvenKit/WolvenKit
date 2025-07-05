using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ControlsActiveEvents : BraindanceControlsTransition
	{
		[Ordinal(0)] 
		[RED("BraindanceBB")] 
		public CWeakHandle<gameIBlackboard> BraindanceBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(1)] 
		[RED("BlockPerspectiveSwitchTimer")] 
		public CFloat BlockPerspectiveSwitchTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("fxActive")] 
		public CBool FxActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("rewindFxActive")] 
		public CBool RewindFxActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("holdDuration")] 
		public CFloat HoldDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("cachedState")] 
		public CEnum<scnPlaySpeed> CachedState
		{
			get => GetPropertyValue<CEnum<scnPlaySpeed>>();
			set => SetPropertyValue<CEnum<scnPlaySpeed>>(value);
		}

		[Ordinal(6)] 
		[RED("cacheSet")] 
		public CBool CacheSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("forwardInput")] 
		public CBool ForwardInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("backwardInput")] 
		public CBool BackwardInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("forwardInputLocked")] 
		public CBool ForwardInputLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("backwardInputLocked")] 
		public CBool BackwardInputLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("activeDirection")] 
		public CEnum<scnPlayDirection> ActiveDirection
		{
			get => GetPropertyValue<CEnum<scnPlayDirection>>();
			set => SetPropertyValue<CEnum<scnPlayDirection>>(value);
		}

		[Ordinal(12)] 
		[RED("rewindRunning")] 
		public CBool RewindRunning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("contextsSetup")] 
		public CBool ContextsSetup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("pauseLock")] 
		public CBool PauseLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("endRecordingMessageSet")] 
		public CBool EndRecordingMessageSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ControlsActiveEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
