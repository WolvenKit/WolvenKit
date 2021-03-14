using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_NPCExploration : animAnimFeature
	{
		private CInt32 _explorationType;
		private CInt32 _state;
		private CInt32 _movementType;
		private CBool _isEvenLoop;

		[Ordinal(0)] 
		[RED("explorationType")] 
		public CInt32 ExplorationType
		{
			get
			{
				if (_explorationType == null)
				{
					_explorationType = (CInt32) CR2WTypeManager.Create("Int32", "explorationType", cr2w, this);
				}
				return _explorationType;
			}
			set
			{
				if (_explorationType == value)
				{
					return;
				}
				_explorationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("movementType")] 
		public CInt32 MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CInt32) CR2WTypeManager.Create("Int32", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isEvenLoop")] 
		public CBool IsEvenLoop
		{
			get
			{
				if (_isEvenLoop == null)
				{
					_isEvenLoop = (CBool) CR2WTypeManager.Create("Bool", "isEvenLoop", cr2w, this);
				}
				return _isEvenLoop;
			}
			set
			{
				if (_isEvenLoop == value)
				{
					return;
				}
				_isEvenLoop = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_NPCExploration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
