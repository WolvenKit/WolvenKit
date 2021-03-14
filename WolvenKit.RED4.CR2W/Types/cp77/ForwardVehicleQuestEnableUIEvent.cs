using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForwardVehicleQuestEnableUIEvent : redEvent
	{
		private CEnum<vehicleQuestUIEnable> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<vehicleQuestUIEnable> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<vehicleQuestUIEnable>) CR2WTypeManager.Create("vehicleQuestUIEnable", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public ForwardVehicleQuestEnableUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
