using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIArgumentOverrideWrapper : RedBaseClass
	{
		private CName _name;
		private CEnum<AIArgumentType> _type;
		private CHandle<AIArgumentDefinition> _definition;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("definition")] 
		public CHandle<AIArgumentDefinition> Definition
		{
			get => GetProperty(ref _definition);
			set => SetProperty(ref _definition, value);
		}
	}
}
