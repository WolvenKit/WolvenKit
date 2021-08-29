using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimTrackParameter : RedBaseClass
	{
		private CName _animTrackName;
		private CName _parameterName;
		private CFloat _defaultValue;

		[Ordinal(0)] 
		[RED("animTrackName")] 
		public CName AnimTrackName
		{
			get => GetProperty(ref _animTrackName);
			set => SetProperty(ref _animTrackName, value);
		}

		[Ordinal(1)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetProperty(ref _parameterName);
			set => SetProperty(ref _parameterName, value);
		}

		[Ordinal(2)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}
	}
}
