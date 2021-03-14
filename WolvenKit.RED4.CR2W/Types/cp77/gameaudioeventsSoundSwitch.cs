using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsSoundSwitch : redEvent
	{
		private CName _switchName;
		private CName _switchValue;

		[Ordinal(0)] 
		[RED("switchName")] 
		public CName SwitchName
		{
			get
			{
				if (_switchName == null)
				{
					_switchName = (CName) CR2WTypeManager.Create("CName", "switchName", cr2w, this);
				}
				return _switchName;
			}
			set
			{
				if (_switchName == value)
				{
					return;
				}
				_switchName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("switchValue")] 
		public CName SwitchValue
		{
			get
			{
				if (_switchValue == null)
				{
					_switchValue = (CName) CR2WTypeManager.Create("CName", "switchValue", cr2w, this);
				}
				return _switchValue;
			}
			set
			{
				if (_switchValue == value)
				{
					return;
				}
				_switchValue = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsSoundSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
