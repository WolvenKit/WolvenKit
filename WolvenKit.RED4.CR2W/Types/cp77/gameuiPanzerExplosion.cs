using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerExplosion : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CName _animationName;

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		public gameuiPanzerExplosion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
