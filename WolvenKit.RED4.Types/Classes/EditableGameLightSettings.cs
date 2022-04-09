using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EditableGameLightSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("modifyStrength")] 
		public CBool ModifyStrength
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("modifyIntensity")] 
		public CBool ModifyIntensity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("modifyRadius")] 
		public CBool ModifyRadius
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(8)] 
		[RED("modifyColor")] 
		public CBool ModifyColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("innerAngle")] 
		public CFloat InnerAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("modifyInnerAngle")] 
		public CBool ModifyInnerAngle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("outerAngle")] 
		public CFloat OuterAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("modifyOuterAngle")] 
		public CBool ModifyOuterAngle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EditableGameLightSettings()
		{
			Color = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
