using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationGenderBackstoryBtn : inkButtonController
	{
		private inkWidgetReference _selector;
		private inkWidgetReference _fluffText;

		[Ordinal(10)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(11)] 
		[RED("fluffText")] 
		public inkWidgetReference FluffText
		{
			get => GetProperty(ref _fluffText);
			set => SetProperty(ref _fluffText, value);
		}

		public characterCreationGenderBackstoryBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
