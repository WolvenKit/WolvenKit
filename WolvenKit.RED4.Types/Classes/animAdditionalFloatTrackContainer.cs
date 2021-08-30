using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAdditionalFloatTrackContainer : RedBaseClass
	{
		private CArray<animAdditionalFloatTrackEntry> _entries;
		private CBool _overwriteExistingValues;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animAdditionalFloatTrackEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(1)] 
		[RED("overwriteExistingValues")] 
		public CBool OverwriteExistingValues
		{
			get => GetProperty(ref _overwriteExistingValues);
			set => SetProperty(ref _overwriteExistingValues, value);
		}

		public animAdditionalFloatTrackContainer()
		{
			_overwriteExistingValues = true;
		}
	}
}
