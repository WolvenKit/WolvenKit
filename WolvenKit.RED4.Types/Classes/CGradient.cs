using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			GradientEntries = new() { new(), new() };
		}
	}
}
