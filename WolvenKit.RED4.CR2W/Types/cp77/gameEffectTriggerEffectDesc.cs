using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectTriggerEffectDesc : ISerializable
	{
		private raRef<worldEffect> _effect;
		private CEnum<gameEffectTriggerPositioningType> _positionType;
		private CEnum<gameEffectTriggerRotationType> _rotationType;
		private Vector3 _offset;
		private CUInt32 _playFromHour;
		private CUInt32 _playTillHour;

		[Ordinal(0)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("positionType")] 
		public CEnum<gameEffectTriggerPositioningType> PositionType
		{
			get
			{
				if (_positionType == null)
				{
					_positionType = (CEnum<gameEffectTriggerPositioningType>) CR2WTypeManager.Create("gameEffectTriggerPositioningType", "positionType", cr2w, this);
				}
				return _positionType;
			}
			set
			{
				if (_positionType == value)
				{
					return;
				}
				_positionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rotationType")] 
		public CEnum<gameEffectTriggerRotationType> RotationType
		{
			get
			{
				if (_rotationType == null)
				{
					_rotationType = (CEnum<gameEffectTriggerRotationType>) CR2WTypeManager.Create("gameEffectTriggerRotationType", "rotationType", cr2w, this);
				}
				return _rotationType;
			}
			set
			{
				if (_rotationType == value)
				{
					return;
				}
				_rotationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playFromHour")] 
		public CUInt32 PlayFromHour
		{
			get
			{
				if (_playFromHour == null)
				{
					_playFromHour = (CUInt32) CR2WTypeManager.Create("Uint32", "playFromHour", cr2w, this);
				}
				return _playFromHour;
			}
			set
			{
				if (_playFromHour == value)
				{
					return;
				}
				_playFromHour = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("playTillHour")] 
		public CUInt32 PlayTillHour
		{
			get
			{
				if (_playTillHour == null)
				{
					_playTillHour = (CUInt32) CR2WTypeManager.Create("Uint32", "playTillHour", cr2w, this);
				}
				return _playTillHour;
			}
			set
			{
				if (_playTillHour == value)
				{
					return;
				}
				_playTillHour = value;
				PropertySet(this);
			}
		}

		public gameEffectTriggerEffectDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
