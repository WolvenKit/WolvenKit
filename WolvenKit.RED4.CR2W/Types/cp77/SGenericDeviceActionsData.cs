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
			get => GetProperty(ref _toggleON);
			set => SetProperty(ref _toggleON, value);
		}

		[Ordinal(1)] 
		[RED("togglePower")] 
		public SDeviceActionBoolData TogglePower
		{
			get => GetProperty(ref _togglePower);
			set => SetProperty(ref _togglePower, value);
		}

		public SGenericDeviceActionsData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
