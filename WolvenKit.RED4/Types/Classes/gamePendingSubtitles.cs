using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePendingSubtitles : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pendingSubtitles")] 
		public CArray<scnDialogLineData> PendingSubtitles
		{
			get => GetPropertyValue<CArray<scnDialogLineData>>();
			set => SetPropertyValue<CArray<scnDialogLineData>>(value);
		}

		public gamePendingSubtitles()
		{
			PendingSubtitles = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
