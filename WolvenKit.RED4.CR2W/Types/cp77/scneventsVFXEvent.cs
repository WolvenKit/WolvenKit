using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsVFXEvent : scnSceneEvent
	{
		private scnEffectEntry _effectEntry;
		private CEnum<scneventsVFXActionType> _action;
		private CUInt32 _sequenceShift;
		private scnPerformerId _performerId;
		private NodeRef _nodeRef;
		private CBool _muteSound;

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("action")] 
		public CEnum<scneventsVFXActionType> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<scneventsVFXActionType>) CR2WTypeManager.Create("scneventsVFXActionType", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("muteSound")] 
		public CBool MuteSound
		{
			get
			{
				if (_muteSound == null)
				{
					_muteSound = (CBool) CR2WTypeManager.Create("Bool", "muteSound", cr2w, this);
				}
				return _muteSound;
			}
			set
			{
				if (_muteSound == value)
				{
					return;
				}
				_muteSound = value;
				PropertySet(this);
			}
		}

		public scneventsVFXEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
