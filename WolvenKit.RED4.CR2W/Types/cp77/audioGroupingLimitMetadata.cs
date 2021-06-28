using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGroupingLimitMetadata : audioAudioMetadata
	{
		private CFloat _limit;

		[Ordinal(1)] 
		[RED("limit")] 
		public CFloat Limit
		{
			get => GetProperty(ref _limit);
			set => SetProperty(ref _limit, value);
		}

		public audioGroupingLimitMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
