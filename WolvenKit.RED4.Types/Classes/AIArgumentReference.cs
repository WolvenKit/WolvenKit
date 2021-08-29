using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIArgumentReference : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private CVariant _defaultValue;
		private CName _rttiClassName;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public CVariant DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		[Ordinal(5)] 
		[RED("rttiClassName")] 
		public CName RttiClassName
		{
			get => GetProperty(ref _rttiClassName);
			set => SetProperty(ref _rttiClassName, value);
		}
	}
}
