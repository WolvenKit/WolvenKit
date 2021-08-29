using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackGroup : effectTrackBase
	{
		private CArray<CHandle<effectTrackBase>> _tracks;
		private CName _componentName;

		[Ordinal(0)] 
		[RED("tracks")] 
		public CArray<CHandle<effectTrackBase>> Tracks
		{
			get => GetProperty(ref _tracks);
			set => SetProperty(ref _tracks, value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}
	}
}
