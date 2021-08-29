using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnIKEvent : scnSceneEvent
	{
		private scnIKEventData _ikData;

		[Ordinal(6)] 
		[RED("ikData")] 
		public scnIKEventData IkData
		{
			get => GetProperty(ref _ikData);
			set => SetProperty(ref _ikData, value);
		}
	}
}
