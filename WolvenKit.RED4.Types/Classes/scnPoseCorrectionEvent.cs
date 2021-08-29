using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnPoseCorrectionEvent : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private animPoseCorrectionGroup _poseCorrectionGroup;

		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(7)] 
		[RED("poseCorrectionGroup")] 
		public animPoseCorrectionGroup PoseCorrectionGroup
		{
			get => GetProperty(ref _poseCorrectionGroup);
			set => SetProperty(ref _poseCorrectionGroup, value);
		}
	}
}
