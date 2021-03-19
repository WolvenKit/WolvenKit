using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePlayerLevelBasedQuestRequestFilter : gameCustomRequestFilter
	{
		private CUInt32 _percentMargin;

		[Ordinal(0)] 
		[RED("percentMargin")] 
		public CUInt32 PercentMargin
		{
			get => GetProperty(ref _percentMargin);
			set => SetProperty(ref _percentMargin, value);
		}

		public gamePlayerLevelBasedQuestRequestFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
