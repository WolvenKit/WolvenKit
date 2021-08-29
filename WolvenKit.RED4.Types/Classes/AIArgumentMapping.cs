using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIArgumentMapping : IScriptable
	{
		private CEnum<AIArgumentType> _type;
		private CEnum<AIParameterizationType> _parameterizationType;
		private CVariant _defaultValue;
		private CHandle<AIArgumentMapping> _prefixValue;
		private CName _customTypeName;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("parameterizationType")] 
		public CEnum<AIParameterizationType> ParameterizationType
		{
			get => GetProperty(ref _parameterizationType);
			set => SetProperty(ref _parameterizationType, value);
		}

		[Ordinal(2)] 
		[RED("defaultValue")] 
		public CVariant DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		[Ordinal(3)] 
		[RED("prefixValue")] 
		public CHandle<AIArgumentMapping> PrefixValue
		{
			get => GetProperty(ref _prefixValue);
			set => SetProperty(ref _prefixValue, value);
		}

		[Ordinal(4)] 
		[RED("customTypeName")] 
		public CName CustomTypeName
		{
			get => GetProperty(ref _customTypeName);
			set => SetProperty(ref _customTypeName, value);
		}
	}
}
