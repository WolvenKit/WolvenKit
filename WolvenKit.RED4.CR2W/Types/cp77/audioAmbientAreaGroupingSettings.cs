using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaGroupingSettings : CVariable
	{
		private CName _groupCountTag;
		private CName _groupCountRtpc;
		private CName _groupAvgDistanceRtpc;
		private CEnum<audioAmbientGroupingVariant> _groupingVariant;
		private CFloat _minDistance;
		private CFloat _maxDistance;

		[Ordinal(0)] 
		[RED("GroupCountTag")] 
		public CName GroupCountTag
		{
			get => GetProperty(ref _groupCountTag);
			set => SetProperty(ref _groupCountTag, value);
		}

		[Ordinal(1)] 
		[RED("GroupCountRtpc")] 
		public CName GroupCountRtpc
		{
			get => GetProperty(ref _groupCountRtpc);
			set => SetProperty(ref _groupCountRtpc, value);
		}

		[Ordinal(2)] 
		[RED("GroupAvgDistanceRtpc")] 
		public CName GroupAvgDistanceRtpc
		{
			get => GetProperty(ref _groupAvgDistanceRtpc);
			set => SetProperty(ref _groupAvgDistanceRtpc, value);
		}

		[Ordinal(3)] 
		[RED("groupingVariant")] 
		public CEnum<audioAmbientGroupingVariant> GroupingVariant
		{
			get => GetProperty(ref _groupingVariant);
			set => SetProperty(ref _groupingVariant, value);
		}

		[Ordinal(4)] 
		[RED("MinDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(5)] 
		[RED("MaxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		public audioAmbientAreaGroupingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
