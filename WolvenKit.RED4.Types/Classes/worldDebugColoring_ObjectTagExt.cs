using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_ObjectTagExt : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CEnum<worldObjectTagExt> Tag
		{
			get => GetPropertyValue<CEnum<worldObjectTagExt>>();
			set => SetPropertyValue<CEnum<worldObjectTagExt>>(value);
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_ObjectTagExt()
		{
			Tag = Enums.worldObjectTagExt.None;
			Color = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
