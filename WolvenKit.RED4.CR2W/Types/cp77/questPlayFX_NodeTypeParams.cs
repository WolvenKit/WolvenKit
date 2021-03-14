using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayFX_NodeTypeParams : CVariable
	{
		private CBool _play;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;
		private CName _effectName;
		private CUInt32 _sequenceShift;

		[Ordinal(0)] 
		[RED("play")] 
		public CBool Play
		{
			get
			{
				if (_play == null)
				{
					_play = (CBool) CR2WTypeManager.Create("Bool", "play", cr2w, this);
				}
				return _play;
			}
			set
			{
				if (_play == value)
				{
					return;
				}
				_play = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public questPlayFX_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
