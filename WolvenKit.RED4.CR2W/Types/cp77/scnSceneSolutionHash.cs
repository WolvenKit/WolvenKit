using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneSolutionHash : CVariable
	{
		private scnSceneSolutionHashHash _sceneSolutionHash;

		[Ordinal(0)] 
		[RED("sceneSolutionHash")] 
		public scnSceneSolutionHashHash SceneSolutionHash
		{
			get => GetProperty(ref _sceneSolutionHash);
			set => SetProperty(ref _sceneSolutionHash, value);
		}

		public scnSceneSolutionHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
