using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericTemplatePersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("primaryColorDefined")] 
		public CBool PrimaryColorDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("primaryColorR")] 
		public CUInt8 PrimaryColorR
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("primaryColorG")] 
		public CUInt8 PrimaryColorG
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("primaryColorB")] 
		public CUInt8 PrimaryColorB
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("secondaryColorDefined")] 
		public CBool SecondaryColorDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("secondaryColorR")] 
		public CUInt8 SecondaryColorR
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(6)] 
		[RED("secondaryColorG")] 
		public CUInt8 SecondaryColorG
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("secondaryColorB")] 
		public CUInt8 SecondaryColorB
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(8)] 
		[RED("lightsColorDefined")] 
		public CBool LightsColorDefined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("lightsColorHue")] 
		public CFloat LightsColorHue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public GenericTemplatePersistentData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
