using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CGradient : CResource
	{
		[Ordinal(1)] 
		[RED("gradientEntries")] 
		public CArray<rendGradientEntry> GradientEntries
		{
			get => GetPropertyValue<CArray<rendGradientEntry>>();
			set => SetPropertyValue<CArray<rendGradientEntry>>(value);
		}

		public CGradient()
		{
			GradientEntries = new() { new rendGradientEntry { Color = new CColor { Alpha = 255 } }, new rendGradientEntry { Value = 1.000000F, Color = new CColor { Red = 255, Green = 255, Blue = 255, Alpha = 255 } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
