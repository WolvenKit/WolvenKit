using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextOffsetAnimationController : inkTextAnimationController
	{
		private CFloat _timeToSkip;

		[Ordinal(8)] 
		[RED("timeToSkip")] 
		public CFloat TimeToSkip
		{
			get => GetProperty(ref _timeToSkip);
			set => SetProperty(ref _timeToSkip, value);
		}

		public inkTextOffsetAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
