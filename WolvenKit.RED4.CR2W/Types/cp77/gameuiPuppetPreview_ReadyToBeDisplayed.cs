using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreview_ReadyToBeDisplayed : redEvent
	{
		private CBool _isMale;

		[Ordinal(0)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get => GetProperty(ref _isMale);
			set => SetProperty(ref _isMale, value);
		}

		public gameuiPuppetPreview_ReadyToBeDisplayed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
