using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISharedVarDefinition : RedBaseClass
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
	}
}
