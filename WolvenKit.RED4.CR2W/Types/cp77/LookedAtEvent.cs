using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LookedAtEvent : redEvent
	{
		private CBool _isLookedAt;

		[Ordinal(0)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetProperty(ref _isLookedAt);
			set => SetProperty(ref _isLookedAt, value);
		}

		public LookedAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
