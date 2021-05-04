using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsCategoryItem : inkListItemController
	{
		private inkTextWidgetReference _labelHighlight;

		[Ordinal(16)] 
		[RED("labelHighlight")] 
		public inkTextWidgetReference LabelHighlight
		{
			get => GetProperty(ref _labelHighlight);
			set => SetProperty(ref _labelHighlight, value);
		}

		public SettingsCategoryItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
