using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsVFXDurationEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("effectEntry")] 
		public scnEffectEntry EffectEntry
		{
			get => GetPropertyValue<scnEffectEntry>();
			set => SetPropertyValue<scnEffectEntry>(value);
		}

		[Ordinal(7)] 
		[RED("startAction")] 
		public CEnum<scneventsVFXActionType> StartAction
		{
			get => GetPropertyValue<CEnum<scneventsVFXActionType>>();
			set => SetPropertyValue<CEnum<scneventsVFXActionType>>(value);
		}

		[Ordinal(8)] 
		[RED("endAction")] 
		public CEnum<scneventsVFXActionType> EndAction
		{
			get => GetPropertyValue<CEnum<scneventsVFXActionType>>();
			set => SetPropertyValue<CEnum<scneventsVFXActionType>>(value);
		}

		[Ordinal(9)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(11)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(12)] 
		[RED("muteSound")] 
		public CBool MuteSound
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scneventsVFXDurationEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			EffectEntry = new scnEffectEntry { EffectInstanceId = new scnEffectInstanceId { EffectId = new scnEffectId { Id = uint.MaxValue }, Id = uint.MaxValue } };
			EndAction = Enums.scneventsVFXActionType.Kill;
			PerformerId = new scnPerformerId { Id = 4294967040 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
