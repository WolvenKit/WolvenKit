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
			GradientEntriesID = new() { new(), new() };
			GradientEntriesRootToTip = new() { new(), new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
