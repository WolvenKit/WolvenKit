using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionColorPickerButton : inkWidgetLogicController
	{
		private inkWidgetReference _background;
		private inkImageWidgetReference _icon;
		private CBool _isTriggered;

		[Ordinal(1)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isTriggered")] 
		public CBool IsTriggered
		{
			get
			{
				if (_isTriggered == null)
				{
					_isTriggered = (CBool) CR2WTypeManager.Create("Bool", "isTriggered", cr2w, this);
				}
				return _isTriggered;
			}
			set
			{
				if (_isTriggered == value)
				{
					return;
				}
				_isTriggered = value;
				PropertySet(this);
			}
		}

		public characterCreationBodyMorphOptionColorPickerButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
