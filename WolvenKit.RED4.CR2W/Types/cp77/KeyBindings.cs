using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KeyBindings : CVariable
	{
		private TweakDBID _dPAD_UP;
		private TweakDBID _rB;

		[Ordinal(0)] 
		[RED("DPAD_UP")] 
		public TweakDBID DPAD_UP
		{
			get
			{
				if (_dPAD_UP == null)
				{
					_dPAD_UP = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "DPAD_UP", cr2w, this);
				}
				return _dPAD_UP;
			}
			set
			{
				if (_dPAD_UP == value)
				{
					return;
				}
				_dPAD_UP = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("RB")] 
		public TweakDBID RB
		{
			get
			{
				if (_rB == null)
				{
					_rB = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "RB", cr2w, this);
				}
				return _rB;
			}
			set
			{
				if (_rB == value)
				{
					return;
				}
				_rB = value;
				PropertySet(this);
			}
		}

		public KeyBindings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
