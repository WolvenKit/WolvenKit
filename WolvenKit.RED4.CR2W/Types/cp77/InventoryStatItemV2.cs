using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatItemV2 : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelRef;
		private inkTextWidgetReference _valueRef;
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _backgroundIcon;
		private inkWidgetReference _textGroup;
		private CBool _introPlayed;

		[Ordinal(1)] 
		[RED("LabelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get
			{
				if (_labelRef == null)
				{
					_labelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "LabelRef", cr2w, this);
				}
				return _labelRef;
			}
			set
			{
				if (_labelRef == value)
				{
					return;
				}
				_labelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ValueRef")] 
		public inkTextWidgetReference ValueRef
		{
			get
			{
				if (_valueRef == null)
				{
					_valueRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ValueRef", cr2w, this);
				}
				return _valueRef;
			}
			set
			{
				if (_valueRef == value)
				{
					return;
				}
				_valueRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "Icon", cr2w, this);
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

		[Ordinal(4)] 
		[RED("BackgroundIcon")] 
		public inkImageWidgetReference BackgroundIcon
		{
			get
			{
				if (_backgroundIcon == null)
				{
					_backgroundIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "BackgroundIcon", cr2w, this);
				}
				return _backgroundIcon;
			}
			set
			{
				if (_backgroundIcon == value)
				{
					return;
				}
				_backgroundIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("TextGroup")] 
		public inkWidgetReference TextGroup
		{
			get
			{
				if (_textGroup == null)
				{
					_textGroup = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TextGroup", cr2w, this);
				}
				return _textGroup;
			}
			set
			{
				if (_textGroup == value)
				{
					return;
				}
				_textGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("IntroPlayed")] 
		public CBool IntroPlayed
		{
			get
			{
				if (_introPlayed == null)
				{
					_introPlayed = (CBool) CR2WTypeManager.Create("Bool", "IntroPlayed", cr2w, this);
				}
				return _introPlayed;
			}
			set
			{
				if (_introPlayed == value)
				{
					return;
				}
				_introPlayed = value;
				PropertySet(this);
			}
		}

		public InventoryStatItemV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
