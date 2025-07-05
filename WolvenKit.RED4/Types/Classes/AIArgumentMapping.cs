using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentMapping : IScriptable
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetPropertyValue<CEnum<AIArgumentType>>();
			set => SetPropertyValue<CEnum<AIArgumentType>>(value);
		}

		[Ordinal(1)] 
		[RED("parameterizationType")] 
		public CEnum<AIParameterizationType> ParameterizationType
		{
			get => GetPropertyValue<CEnum<AIParameterizationType>>();
			set => SetPropertyValue<CEnum<AIParameterizationType>>(value);
		}

		[Ordinal(2)] 
		[RED("defaultValue")] 
		public CVariant DefaultValue
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		[Ordinal(3)] 
		[RED("prefixValue")] 
		public CHandle<AIArgumentMapping> PrefixValue
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("customTypeName")] 
		public CName CustomTypeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIArgumentMapping()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
