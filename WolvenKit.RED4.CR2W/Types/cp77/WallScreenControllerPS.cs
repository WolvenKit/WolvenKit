using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WallScreenControllerPS : TVControllerPS
	{
		private CBool _isShown;

		[Ordinal(113)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetProperty(ref _isShown);
			set => SetProperty(ref _isShown, value);
		}

		public WallScreenControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
