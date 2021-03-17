using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealQuickhackMenu : HUDManagerRequest
	{
		private CBool _shouldOpenWheel;

		[Ordinal(1)] 
		[RED("shouldOpenWheel")] 
		public CBool ShouldOpenWheel
		{
			get => GetProperty(ref _shouldOpenWheel);
			set => SetProperty(ref _shouldOpenWheel, value);
		}

		public RevealQuickhackMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
