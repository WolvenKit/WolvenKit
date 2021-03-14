using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ButtonHints : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _horizontalHolder;

		[Ordinal(1)] 
		[RED("horizontalHolder")] 
		public inkCompoundWidgetReference HorizontalHolder
		{
			get
			{
				if (_horizontalHolder == null)
				{
					_horizontalHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "horizontalHolder", cr2w, this);
				}
				return _horizontalHolder;
			}
			set
			{
				if (_horizontalHolder == value)
				{
					return;
				}
				_horizontalHolder = value;
				PropertySet(this);
			}
		}

		public ButtonHints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
