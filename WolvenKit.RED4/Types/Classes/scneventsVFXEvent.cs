using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsVFXEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("effectEntry")] 
		public scnEffectEntry EffectEntry
		{
			get => GetPropertyValue<scnEffectEntry>();
			set => SetPropertyValue<scnEffectEntry>(value);
		}

		[Ordinal(7)] 
		[RED("action")] 
		public CEnum<scneventsVFXActionType> Action
		{
			get => GetPropertyValue<CEnum<scneventsVFXActionType>>();
			set => SetPropertyValue<CEnum<scneventsVFXActionType>>(value);
		}

		[Ordinal(8)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(10)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(11)] 
		[RED("muteSound")] 
		public CBool MuteSound
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scneventsVFXEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			EffectEntry = new() { EffectInstanceId = new() { EffectId = new() { Id = 4294967295 }, Id = 4294967295 } };
			PerformerId = new() { Id = 4294967040 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
