using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_DistanceFromRoot : gameEffectObjectGroupFilter
	{
		private CFloat _rootZOffset;
		private CFloat _bonusRange;

		[Ordinal(0)] 
		[RED("rootZOffset")] 
		public CFloat RootZOffset
		{
			get => GetProperty(ref _rootZOffset);
			set => SetProperty(ref _rootZOffset, value);
		}

		[Ordinal(1)] 
		[RED("bonusRange")] 
		public CFloat BonusRange
		{
			get => GetProperty(ref _bonusRange);
			set => SetProperty(ref _bonusRange, value);
		}

		public gameEffectObjectFilter_DistanceFromRoot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
