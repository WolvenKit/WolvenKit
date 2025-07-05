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
			GradientEntries = new() { new rendGradientEntry(), new rendGradientEntry() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
