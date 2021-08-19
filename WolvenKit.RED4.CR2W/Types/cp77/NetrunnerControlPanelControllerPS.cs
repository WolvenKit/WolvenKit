using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetrunnerControlPanelControllerPS : BasicDistractionDeviceControllerPS
	{
		private ComputerQuickHackData _factQuickHackSetup;
		private CBool _quickhackPerformed;

		[Ordinal(109)] 
		[RED("factQuickHackSetup")] 
		public ComputerQuickHackData FactQuickHackSetup
		{
			get => GetProperty(ref _factQuickHackSetup);
			set => SetProperty(ref _factQuickHackSetup, value);
		}

		[Ordinal(110)] 
		[RED("quickhackPerformed")] 
		public CBool QuickhackPerformed
		{
			get => GetProperty(ref _quickhackPerformed);
			set => SetProperty(ref _quickhackPerformed, value);
		}

		public NetrunnerControlPanelControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
