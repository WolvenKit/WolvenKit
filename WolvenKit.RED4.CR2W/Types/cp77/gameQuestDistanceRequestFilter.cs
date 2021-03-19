using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameQuestDistanceRequestFilter : gameCustomRequestFilter
	{
		private CFloat _distanceSquared;

		[Ordinal(0)] 
		[RED("distanceSquared")] 
		public CFloat DistanceSquared
		{
			get => GetProperty(ref _distanceSquared);
			set => SetProperty(ref _distanceSquared, value);
		}

		public gameQuestDistanceRequestFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
