using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnscreenDisplayManager : inkWidgetLogicController
	{
		private inkTextWidgetReference _contentText;

		[Ordinal(1)] 
		[RED("contentText")] 
		public inkTextWidgetReference ContentText
		{
			get
			{
				if (_contentText == null)
				{
					_contentText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "contentText", cr2w, this);
				}
				return _contentText;
			}
			set
			{
				if (_contentText == value)
				{
					return;
				}
				_contentText = value;
				PropertySet(this);
			}
		}

		public OnscreenDisplayManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
