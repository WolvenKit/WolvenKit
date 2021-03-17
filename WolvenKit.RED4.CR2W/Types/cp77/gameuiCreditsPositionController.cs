using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsPositionController : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleText;
		private inkTextWidgetReference _namesText;

		[Ordinal(1)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(2)] 
		[RED("namesText")] 
		public inkTextWidgetReference NamesText
		{
			get => GetProperty(ref _namesText);
			set => SetProperty(ref _namesText, value);
		}

		public gameuiCreditsPositionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
