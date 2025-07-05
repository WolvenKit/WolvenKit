using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStaticAreaShapeComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("outline")] 
		public CHandle<AreaShapeOutline> Outline
		{
			get => GetPropertyValue<CHandle<AreaShapeOutline>>();
			set => SetPropertyValue<CHandle<AreaShapeOutline>>(value);
		}

		[Ordinal(6)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(7)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameStaticAreaShapeComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			Color = new CColor();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
