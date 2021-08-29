using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSetCameraParamsEvent : redEvent
	{
		private CName _paramsName;

		[Ordinal(0)] 
		[RED("paramsName")] 
		public CName ParamsName
		{
			get => GetProperty(ref _paramsName);
			set => SetProperty(ref _paramsName, value);
		}
	}
}
