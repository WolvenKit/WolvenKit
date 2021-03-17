using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTargetingLocalizedEffectComponent : entIComponent
	{
		private CFloat _streamingDistance;
		private CFloat _visibleTargetRange;

		[Ordinal(3)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}

		[Ordinal(4)] 
		[RED("visibleTargetRange")] 
		public CFloat VisibleTargetRange
		{
			get => GetProperty(ref _visibleTargetRange);
			set => SetProperty(ref _visibleTargetRange, value);
		}

		public gameTargetingLocalizedEffectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
