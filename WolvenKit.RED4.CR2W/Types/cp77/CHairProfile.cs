using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CHairProfile : CResource
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

		public CHairProfile(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
