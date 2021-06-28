using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneSolutionHashHash : CVariable
	{
		private CUInt64 _sceneSolutionHashDate;

		[Ordinal(0)] 
		[RED("sceneSolutionHashDate")] 
		public CUInt64 SceneSolutionHashDate
		{
			get => GetProperty(ref _sceneSolutionHashDate);
			set => SetProperty(ref _sceneSolutionHashDate, value);
		}

		public scnSceneSolutionHashHash(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
