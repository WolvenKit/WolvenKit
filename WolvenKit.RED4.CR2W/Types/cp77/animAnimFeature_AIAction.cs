using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_AIAction : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _animVariation;
		private CFloat _stateDuration;
		private CFloat _direction;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get
			{
				if (_animVariation == null)
				{
					_animVariation = (CInt32) CR2WTypeManager.Create("Int32", "animVariation", cr2w, this);
				}
				return _animVariation;
			}
			set
			{
				if (_animVariation == value)
				{
					return;
				}
				_animVariation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stateDuration")] 
		public CFloat StateDuration
		{
			get
			{
				if (_stateDuration == null)
				{
					_stateDuration = (CFloat) CR2WTypeManager.Create("Float", "stateDuration", cr2w, this);
				}
				return _stateDuration;
			}
			set
			{
				if (_stateDuration == value)
				{
					return;
				}
				_stateDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("direction")] 
		public CFloat Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CFloat) CR2WTypeManager.Create("Float", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_AIAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
