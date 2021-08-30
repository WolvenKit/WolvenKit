using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIArgumentEnumValue : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private CName _enumClass;
		private CInt64 _defaultValue;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("enumClass")] 
		public CName EnumClass
		{
			get => GetProperty(ref _enumClass);
			set => SetProperty(ref _enumClass, value);
		}

		[Ordinal(5)] 
		[RED("defaultValue")] 
		public CInt64 DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public AIArgumentEnumValue()
		{
			_type = new() { Value = Enums.AIArgumentType.Enum };
		}
	}
}
