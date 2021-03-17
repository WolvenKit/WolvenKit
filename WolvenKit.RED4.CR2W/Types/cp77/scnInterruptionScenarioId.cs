using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterruptionScenarioId : CVariable
	{
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public scnInterruptionScenarioId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
