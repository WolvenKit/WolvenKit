using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPlayerReachablePrereq : gameIScriptablePrereq
	{
		private CBool _invert;
		private CBool _checkRMA;

		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		[Ordinal(1)] 
		[RED("checkRMA")] 
		public CBool CheckRMA
		{
			get => GetProperty(ref _checkRMA);
			set => SetProperty(ref _checkRMA, value);
		}

		public IsPlayerReachablePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
