using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerList : SettingsSelectorControllerRange
	{
		private inkHorizontalPanelWidgetReference _dotsContainer;

		[Ordinal(19)] 
		[RED("dotsContainer")] 
		public inkHorizontalPanelWidgetReference DotsContainer
		{
			get
			{
				if (_dotsContainer == null)
				{
					_dotsContainer = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "dotsContainer", cr2w, this);
				}
				return _dotsContainer;
			}
			set
			{
				if (_dotsContainer == value)
				{
					return;
				}
				_dotsContainer = value;
				PropertySet(this);
			}
		}

		public SettingsSelectorControllerList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
