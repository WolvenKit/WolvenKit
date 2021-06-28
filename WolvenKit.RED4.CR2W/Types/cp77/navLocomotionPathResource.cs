using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathResource : CResource
	{
		private CArray<CHandle<navLocomotionPath>> _paths;

		[Ordinal(1)] 
		[RED("paths")] 
		public CArray<CHandle<navLocomotionPath>> Paths
		{
			get => GetProperty(ref _paths);
			set => SetProperty(ref _paths, value);
		}

		public navLocomotionPathResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
