using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CHairProfile : CResource
	{
		private CUInt16 _sampleCount;
		private CArray<rendGradientEntry> _gradientEntriesID;
		private CArray<rendGradientEntry> _gradientEntriesRootToTip;

		[Ordinal(1)] 
		[RED("sampleCount")] 
		public CUInt16 SampleCount
		{
			get => GetProperty(ref _sampleCount);
			set => SetProperty(ref _sampleCount, value);
		}

		[Ordinal(2)] 
		[RED("gradientEntriesID")] 
		public CArray<rendGradientEntry> GradientEntriesID
		{
			get => GetProperty(ref _gradientEntriesID);
			set => SetProperty(ref _gradientEntriesID, value);
		}

		[Ordinal(3)] 
		[RED("gradientEntriesRootToTip")] 
		public CArray<rendGradientEntry> GradientEntriesRootToTip
		{
			get => GetProperty(ref _gradientEntriesRootToTip);
			set => SetProperty(ref _gradientEntriesRootToTip, value);
		}
	}
}
