using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AOEAreaControllerPS : MasterControllerPS
	{
		private AOEAreaSetup _aOEAreaSetup;

		[Ordinal(104)] 
		[RED("AOEAreaSetup")] 
		public AOEAreaSetup AOEAreaSetup
		{
			get => GetProperty(ref _aOEAreaSetup);
			set => SetProperty(ref _aOEAreaSetup, value);
		}

		public AOEAreaControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
