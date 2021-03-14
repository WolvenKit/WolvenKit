using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SGenericDeviceActionsData : CVariable
	{
		private SDeviceActionBoolData _toggleON;
		private SDeviceActionBoolData _togglePower;

		[Ordinal(0)] 
		[RED("toggleON")] 
		public SDeviceActionBoolData ToggleON
		{
			get
			{
				if (_toggleON == null)
				{
					_toggleON = (SDeviceActionBoolData) CR2WTypeManager.Create("SDeviceActionBoolData", "toggleON", cr2w, this);
				}
				return _toggleON;
			}
			set
			{
				if (_toggleON == value)
				{
					return;
				}
				_toggleON = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("togglePower")] 
		public SDeviceActionBoolData TogglePower
		{
			get
			{
				if (_togglePower == null)
				{
					_togglePower = (SDeviceActionBoolData) CR2WTypeManager.Create("SDeviceActionBoolData", "togglePower", cr2w, this);
				}
				return _togglePower;
			}
			set
			{
				if (_togglePower == value)
				{
					return;
				}
				_togglePower = value;
				PropertySet(this);
			}
		}

		public SGenericDeviceActionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
