using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_Duplicates : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("duplicateColor")] 
		public CColor DuplicateColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("refreshPrefab")] 
		public CResourceReference<worldPrefab> RefreshPrefab
		{
			get => GetPropertyValue<CResourceReference<worldPrefab>>();
			set => SetPropertyValue<CResourceReference<worldPrefab>>(value);
		}

		[Ordinal(3)] 
		[RED("refresh")] 
		public CBool Refresh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldDebugColoring_Duplicates()
		{
			DefaultColor = new();
			DuplicateColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
