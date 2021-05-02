using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISharedVarDefinition : CVariable
	{
		private CEnum<AIESharedVarDefinitionType> _type;
		private LibTreeSharedVarRegistrationName _name;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<AIESharedVarDefinitionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public LibTreeSharedVarRegistrationName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		public AISharedVarDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
