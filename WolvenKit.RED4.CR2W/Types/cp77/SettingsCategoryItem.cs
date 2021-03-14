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
			get
			{
				if (_labelHighlight == null)
				{
					_labelHighlight = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "labelHighlight", cr2w, this);
				}
				return _labelHighlight;
			}
			set
			{
				if (_labelHighlight == value)
				{
					return;
				}
				_labelHighlight = value;
				PropertySet(this);
			}
		}

		public SettingsCategoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
