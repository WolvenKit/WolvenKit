using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_CollisionMeshes : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("prefabColor")] 
		public CColor PrefabColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("collisionMeshColor")] 
		public CColor CollisionMeshColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_CollisionMeshes()
		{
			DefaultColor = new CColor { Red = 255, Green = 255, Blue = 255, Alpha = 255 };
			PrefabColor = new CColor { Red = 255, Green = 255, Alpha = 255 };
			CollisionMeshColor = new CColor { Red = 255, Alpha = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
