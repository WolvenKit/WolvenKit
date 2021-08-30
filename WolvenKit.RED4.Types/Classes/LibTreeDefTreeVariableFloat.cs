using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeDefTreeVariableFloat : LibTreeDefTreeVariable
	{
		private CBool _exportAsProperty;
		private CFloat _defaultValue;

		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get => GetProperty(ref _exportAsProperty);
			set => SetProperty(ref _exportAsProperty, value);
		}

		[Ordinal(3)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public LibTreeDefTreeVariableFloat()
		{
			_exportAsProperty = true;
		}
	}
}
