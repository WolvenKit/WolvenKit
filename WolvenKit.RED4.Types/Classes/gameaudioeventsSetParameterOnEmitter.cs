using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsSetParameterOnEmitter : gameaudioeventsEmitterEvent
	{
		private CName _paramName;
		private CFloat _paramValue;

		[Ordinal(1)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get => GetProperty(ref _paramName);
			set => SetProperty(ref _paramName, value);
		}

		[Ordinal(2)] 
		[RED("paramValue")] 
		public CFloat ParamValue
		{
			get => GetProperty(ref _paramValue);
			set => SetProperty(ref _paramValue, value);
		}
	}
}
