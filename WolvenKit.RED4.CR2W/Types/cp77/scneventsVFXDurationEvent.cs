using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsVFXDurationEvent : scnSceneEvent
	{
		private scnEffectEntry _effectEntry;
		private CEnum<scneventsVFXActionType> _startAction;
		private CEnum<scneventsVFXActionType> _endAction;
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
		[RED("startAction")] 
		public CEnum<scneventsVFXActionType> StartAction
		{
			get
			{
				if (_startAction == null)
				{
					_startAction = (CEnum<scneventsVFXActionType>) CR2WTypeManager.Create("scneventsVFXActionType", "startAction", cr2w, this);
				}
				return _startAction;
			}
			set
			{
				if (_startAction == value)
				{
					return;
				}
				_startAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("endAction")] 
		public CEnum<scneventsVFXActionType> EndAction
		{
			get
			{
				if (_endAction == null)
				{
					_endAction = (CEnum<scneventsVFXActionType>) CR2WTypeManager.Create("scneventsVFXActionType", "endAction", cr2w, this);
				}
				return _endAction;
			}
			set
			{
				if (_endAction == value)
				{
					return;
				}
				_endAction = value;
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		public scneventsVFXDurationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
