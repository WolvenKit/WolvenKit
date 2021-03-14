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
			get
			{
				if (_performerId == null)
				{
					_performerId = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performerId", cr2w, this);
				}
				return _performerId;
			}
			set
			{
				if (_performerId == value)
				{
					return;
				}
				_performerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("effectEntry")] 
		public scnEffectEntry EffectEntry
		{
			get
			{
				if (_effectEntry == null)
				{
					_effectEntry = (scnEffectEntry) CR2WTypeManager.Create("scnEffectEntry", "effectEntry", cr2w, this);
				}
				return _effectEntry;
			}
			set
			{
				if (_effectEntry == value)
				{
					return;
				}
				_effectEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("sequenceShift")] 
		public CUInt32 SequenceShift
		{
			get
			{
				if (_sequenceShift == null)
				{
					_sequenceShift = (CUInt32) CR2WTypeManager.Create("Uint32", "sequenceShift", cr2w, this);
				}
				return _sequenceShift;
			}
			set
			{
				if (_sequenceShift == value)
				{
					return;
				}
				_sequenceShift = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("glitchEffectEntry")] 
		public scnEffectEntry GlitchEffectEntry
		{
			get
			{
				if (_glitchEffectEntry == null)
				{
					_glitchEffectEntry = (scnEffectEntry) CR2WTypeManager.Create("scnEffectEntry", "glitchEffectEntry", cr2w, this);
				}
				return _glitchEffectEntry;
			}
			set
			{
				if (_glitchEffectEntry == value)
				{
					return;
				}
				_glitchEffectEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("glitchSequenceShift")] 
		public CUInt32 GlitchSequenceShift
		{
			get
			{
				if (_glitchSequenceShift == null)
				{
					_glitchSequenceShift = (CUInt32) CR2WTypeManager.Create("Uint32", "glitchSequenceShift", cr2w, this);
				}
				return _glitchSequenceShift;
			}
			set
			{
				if (_glitchSequenceShift == value)
				{
					return;
				}
				_glitchSequenceShift = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("fullyRewindable")] 
		public CBool FullyRewindable
		{
			get
			{
				if (_fullyRewindable == null)
				{
					_fullyRewindable = (CBool) CR2WTypeManager.Create("Bool", "fullyRewindable", cr2w, this);
				}
				return _fullyRewindable;
			}
			set
			{
				if (_fullyRewindable == value)
				{
					return;
				}
				_fullyRewindable = value;
				PropertySet(this);
			}
		}

		public scneventsVFXBraindanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
