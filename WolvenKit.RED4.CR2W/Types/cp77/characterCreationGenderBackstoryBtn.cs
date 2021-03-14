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
			get
			{
				if (_selector == null)
				{
					_selector = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selector", cr2w, this);
				}
				return _selector;
			}
			set
			{
				if (_selector == value)
				{
					return;
				}
				_selector = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("fluffText")] 
		public inkWidgetReference FluffText
		{
			get
			{
				if (_fluffText == null)
				{
					_fluffText = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fluffText", cr2w, this);
				}
				return _fluffText;
			}
			set
			{
				if (_fluffText == value)
				{
					return;
				}
				_fluffText = value;
				PropertySet(this);
			}
		}

		public characterCreationGenderBackstoryBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
