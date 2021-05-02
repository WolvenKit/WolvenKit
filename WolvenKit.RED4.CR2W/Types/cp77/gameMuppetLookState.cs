using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetLookState : CVariable
	{
		private EulerAngles _lookDir;

		[Ordinal(0)] 
		[RED("lookDir")] 
		public EulerAngles LookDir
		{
			get => GetProperty(ref _lookDir);
			set => SetProperty(ref _lookDir, value);
		}

		public gameMuppetLookState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
