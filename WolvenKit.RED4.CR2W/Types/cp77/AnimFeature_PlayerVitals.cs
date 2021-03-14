using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerVitals : animAnimFeature
	{
		private CInt32 _state;
		private CFloat _stateDuration;

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

		public AnimFeature_PlayerVitals(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
