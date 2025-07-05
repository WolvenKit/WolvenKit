using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAdditionalFloatTrackContainer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animAdditionalFloatTrackEntry> Entries
		{
			get => GetPropertyValue<CArray<animAdditionalFloatTrackEntry>>();
			set => SetPropertyValue<CArray<animAdditionalFloatTrackEntry>>(value);
		}

		[Ordinal(1)] 
		[RED("overwriteExistingValues")] 
		public CBool OverwriteExistingValues
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAdditionalFloatTrackContainer()
		{
			Entries = new();
			OverwriteExistingValues = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
