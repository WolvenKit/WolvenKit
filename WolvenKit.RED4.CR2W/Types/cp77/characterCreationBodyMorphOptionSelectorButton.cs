using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionSelectorButton : inkWidgetLogicController
	{
		private inkWidgetReference _overArrow;

		[Ordinal(1)] 
		[RED("overArrow")] 
		public inkWidgetReference OverArrow
		{
			get
			{
				if (_overArrow == null)
				{
					_overArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "overArrow", cr2w, this);
				}
				return _overArrow;
			}
			set
			{
				if (_overArrow == value)
				{
					return;
				}
				_overArrow = value;
				PropertySet(this);
			}
		}

		public characterCreationBodyMorphOptionSelectorButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
