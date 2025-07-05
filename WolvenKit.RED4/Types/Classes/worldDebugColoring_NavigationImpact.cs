using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_NavigationImpact : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("walkable")] 
		public CColor Walkable
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("ignored")] 
		public CColor Ignored
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("blocking")] 
		public CColor Blocking
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("road")] 
		public CColor Road
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(4)] 
		[RED("stairs walkable")] 
		public CColor Stairs_walkable
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(5)] 
		[RED("drones")] 
		public CColor Drones
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(6)] 
		[RED("terrain")] 
		public CColor Terrain
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(7)] 
		[RED("everything else")] 
		public CColor Everything_else
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_NavigationImpact()
		{
			Walkable = new CColor();
			Ignored = new CColor();
			Blocking = new CColor();
			Road = new CColor();
			Stairs_walkable = new CColor();
			Drones = new CColor();
			Terrain = new CColor();
			Everything_else = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
