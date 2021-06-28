using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FanControllerPS : BasicDistractionDeviceControllerPS
	{
		private FanSetup _fanSetup;

		[Ordinal(108)] 
		[RED("fanSetup")] 
		public FanSetup FanSetup
		{
			get => GetProperty(ref _fanSetup);
			set => SetProperty(ref _fanSetup, value);
		}

		public FanControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
