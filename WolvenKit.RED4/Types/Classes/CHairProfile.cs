using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CHairProfile : CResource
	{
		[Ordinal(1)] 
		[RED("sampleCount")] 
		public CUInt16 SampleCount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("gradientEntriesID")] 
		public CArray<rendGradientEntry> GradientEntriesID
		{
			get => GetPropertyValue<CArray<rendGradientEntry>>();
			set => SetPropertyValue<CArray<rendGradientEntry>>(value);
		}

		[Ordinal(3)] 
		[RED("gradientEntriesRootToTip")] 
		public CArray<rendGradientEntry> GradientEntriesRootToTip
		{
			get => GetPropertyValue<CArray<rendGradientEntry>>();
			set => SetPropertyValue<CArray<rendGradientEntry>>(value);
		}

		public CHairProfile()
		{
			SampleCount = 64;
			GradientEntriesID = new() { new rendGradientEntry { Color = new CColor { Red = 245, Green = 222, Blue = 179, Alpha = 255 } }, new rendGradientEntry { Value = 1.000000F, Color = new CColor { Red = 139, Green = 69, Blue = 19, Alpha = 255 } } };
			GradientEntriesRootToTip = new() { new rendGradientEntry { Color = new CColor { Red = 51, Green = 51, Blue = 51, Alpha = 255 } }, new rendGradientEntry { Value = 1.000000F, Color = new CColor { Red = 99, Green = 99, Blue = 99, Alpha = 255 } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
