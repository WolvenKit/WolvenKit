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
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		public ForwardVehicleQuestEnableUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
