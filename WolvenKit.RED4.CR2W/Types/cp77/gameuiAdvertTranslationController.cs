using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAdvertTranslationController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _advertText;

		[Ordinal(2)] 
		[RED("advertText")] 
		public inkTextWidgetReference AdvertText
		{
			get => GetProperty(ref _advertText);
			set => SetProperty(ref _advertText, value);
		}

		public gameuiAdvertTranslationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
