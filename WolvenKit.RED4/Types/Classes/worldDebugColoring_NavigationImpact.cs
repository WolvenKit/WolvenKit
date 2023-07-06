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
		[RED("crowd walkable")] 
		public CColor Crowd_walkable
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(5)] 
		[RED("staris walkable")] 
		public CColor Staris_walkable
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(6)] 
		[RED("drones")] 
		public CColor Drones
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(7)] 
		[RED("everythign else")] 
		public CColor Everythign_else
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
			Crowd_walkable = new CColor();
			Staris_walkable = new CColor();
			Drones = new CColor();
			Everythign_else = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
