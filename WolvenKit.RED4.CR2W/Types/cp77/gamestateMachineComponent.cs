using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineComponent : gamePlayerControlledComponent
	{
		private CString _packageName;

		[Ordinal(3)] 
		[RED("packageName")] 
		public CString PackageName
		{
			get => GetProperty(ref _packageName);
			set => SetProperty(ref _packageName, value);
		}

		public gamestateMachineComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
