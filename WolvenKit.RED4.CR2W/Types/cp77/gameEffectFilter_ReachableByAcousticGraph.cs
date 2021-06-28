using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectFilter_ReachableByAcousticGraph : gameEffectObjectSingleFilter
	{
		private gameEffectInputParameter_Float _maxPathLength;

		[Ordinal(0)] 
		[RED("maxPathLength")] 
		public gameEffectInputParameter_Float MaxPathLength
		{
			get => GetProperty(ref _maxPathLength);
			set => SetProperty(ref _maxPathLength, value);
		}

		public gameEffectFilter_ReachableByAcousticGraph(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
