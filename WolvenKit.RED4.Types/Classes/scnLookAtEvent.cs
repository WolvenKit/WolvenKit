using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnLookAtEvent : scnSceneEvent
	{
		private scnLookAtBasicEventData _basicData;

		[Ordinal(6)] 
		[RED("basicData")] 
		public scnLookAtBasicEventData BasicData
		{
			get => GetProperty(ref _basicData);
			set => SetProperty(ref _basicData, value);
		}
	}
}
