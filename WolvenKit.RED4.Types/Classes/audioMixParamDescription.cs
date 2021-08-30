using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMixParamDescription : RedBaseClass
	{
		private CName _parameter;
		private CFloat _defaultValue;

		[Ordinal(0)] 
		[RED("parameter")] 
		public CName Parameter
		{
			get => GetProperty(ref _parameter);
			set => SetProperty(ref _parameter, value);
		}

		[Ordinal(1)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public audioMixParamDescription()
		{
			_defaultValue = 1.000000F;
		}
	}
}
