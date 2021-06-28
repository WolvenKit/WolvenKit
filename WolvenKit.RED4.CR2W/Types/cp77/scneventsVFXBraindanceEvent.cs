using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsVFXBraindanceEvent : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private NodeRef _nodeRef;
		private scnEffectEntry _effectEntry;
		private CUInt32 _sequenceShift;
		private scnEffectEntry _glitchEffectEntry;
		private CUInt32 _glitchSequenceShift;
		private CBool _fullyRewindable;

		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(7)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(8)] 
		[RED("effectEntry")] 
		public scnEffectEntry EffectEntry
		{
			get => GetProperty(ref _effectEntry);
			set => SetProperty(ref _effectEntry, value);
		}

		[Ordinal(9)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get => GetProperty(ref _sequenceShift);
			set => SetProperty(ref _sequenceShift, value);
		}

		[Ordinal(10)] 
		[RED("glitchEffectEntry")] 
		public scnEffectEntry GlitchEffectEntry
		{
			get => GetProperty(ref _glitchEffectEntry);
			set => SetProperty(ref _glitchEffectEntry, value);
		}

		[Ordinal(11)] 
		[RED("glitchSequenceShift")] 
		public CUInt32 GlitchSequenceShift
		{
			get => GetProperty(ref _glitchSequenceShift);
			set => SetProperty(ref _glitchSequenceShift, value);
		}

		[Ordinal(12)] 
		[RED("fullyRewindable")] 
		public CBool FullyRewindable
		{
			get => GetProperty(ref _fullyRewindable);
			set => SetProperty(ref _fullyRewindable, value);
		}

		public scneventsVFXBraindanceEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
