using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVisualModdingDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("primaryColorDefined")] 
		public CBool PrimaryColorDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("primaryColorH")] 
		public CFloat PrimaryColorH
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("primaryColorS")] 
		public CFloat PrimaryColorS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("primaryColorB")] 
		public CFloat PrimaryColorB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("secondaryColorDefined")] 
		public CBool SecondaryColorDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("secondaryColorH")] 
		public CFloat SecondaryColorH
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("secondaryColorS")] 
		public CFloat SecondaryColorS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("secondaryColorB")] 
		public CFloat SecondaryColorB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("lightsColorDefined")] 
		public CBool LightsColorDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("lightsColorH")] 
		public CFloat LightsColorH
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("decoPreset")] 
		public CInt32 DecoPreset
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("defaultAppearance")] 
		public CName DefaultAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public vehicleVisualModdingDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
