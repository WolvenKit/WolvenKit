using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeDefTreeVariableEnum : LibTreeDefTreeVariable
	{
		private CBool _exportAsProperty;
		private CName _enumClass;
		private CInt64 _defaultValue;

		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get => GetProperty(ref _exportAsProperty);
			set => SetProperty(ref _exportAsProperty, value);
		}

		[Ordinal(3)] 
		[RED("enumClass")] 
		public CName EnumClass
		{
			get => GetProperty(ref _enumClass);
			set => SetProperty(ref _enumClass, value);
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public CInt64 DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public LibTreeDefTreeVariableEnum()
		{
			_exportAsProperty = true;
		}
	}
}
