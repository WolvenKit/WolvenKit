using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsVFXBraindanceEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(8)] 
		[RED("effectEntry")] 
		public scnEffectEntry EffectEntry
		{
			get => GetPropertyValue<scnEffectEntry>();
			set => SetPropertyValue<scnEffectEntry>(value);
		}

		[Ordinal(9)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("glitchEffectEntry")] 
		public scnEffectEntry GlitchEffectEntry
		{
			get => GetPropertyValue<scnEffectEntry>();
			set => SetPropertyValue<scnEffectEntry>(value);
		}

		[Ordinal(11)] 
		[RED("glitchSequenceShift")] 
		public CUInt32 GlitchSequenceShift
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("fullyRewindable")] 
		public CBool FullyRewindable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scneventsVFXBraindanceEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			PerformerId = new scnPerformerId { Id = 4294967040 };
			EffectEntry = new scnEffectEntry { EffectInstanceId = new scnEffectInstanceId { EffectId = new scnEffectId { Id = uint.MaxValue }, Id = uint.MaxValue } };
			GlitchEffectEntry = new scnEffectEntry { EffectInstanceId = new scnEffectInstanceId { EffectId = new scnEffectId { Id = uint.MaxValue }, Id = uint.MaxValue } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
