using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_ObjectTag : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CEnum<worldObjectTag> Tag
		{
			get => GetPropertyValue<CEnum<worldObjectTag>>();
			set => SetPropertyValue<CEnum<worldObjectTag>>(value);
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_ObjectTag()
		{
			Tag = Enums.worldObjectTag.None;
			Color = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
