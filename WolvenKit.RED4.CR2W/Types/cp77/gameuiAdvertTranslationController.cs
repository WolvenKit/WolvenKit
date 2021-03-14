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
			get
			{
				if (_advertText == null)
				{
					_advertText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "advertText", cr2w, this);
				}
				return _advertText;
			}
			set
			{
				if (_advertText == value)
				{
					return;
				}
				_advertText = value;
				PropertySet(this);
			}
		}

		public gameuiAdvertTranslationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
