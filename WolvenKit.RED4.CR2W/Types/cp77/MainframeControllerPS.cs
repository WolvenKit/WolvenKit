using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MainframeControllerPS : BaseAnimatedDeviceControllerPS
	{
		private ComputerQuickHackData _factName;

		[Ordinal(108)] 
		[RED("factName")] 
		public ComputerQuickHackData FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		public MainframeControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
