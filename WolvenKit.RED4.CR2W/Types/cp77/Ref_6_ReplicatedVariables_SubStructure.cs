using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_6_ReplicatedVariables_SubStructure : CVariable
	{
		private CBool _exampleSubStructureVar;

		[Ordinal(0)] 
		[RED("exampleSubStructureVar")] 
		public CBool ExampleSubStructureVar
		{
			get => GetProperty(ref _exampleSubStructureVar);
			set => SetProperty(ref _exampleSubStructureVar, value);
		}

		public Ref_6_ReplicatedVariables_SubStructure(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
