using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGenericSystemNotificationLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleTextWidget;
		private inkTextWidgetReference _descriptionTextWidget;
		private inkTextWidgetReference _additionalDataTextWidget;
		private CName _introAnimationName;
		private CName _outroAnimationName;
		private inkWidgetReference _confirmButton;
		private inkWidgetReference _cancelButton;

		[Ordinal(1)] 
		[RED("titleTextWidget")] 
		public inkTextWidgetReference TitleTextWidget
		{
			get
			{
				if (_titleTextWidget == null)
				{
					_titleTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleTextWidget", cr2w, this);
				}
				return _titleTextWidget;
			}
			set
			{
				if (_titleTextWidget == value)
				{
					return;
				}
				_titleTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("descriptionTextWidget")] 
		public inkTextWidgetReference DescriptionTextWidget
		{
			get
			{
				if (_descriptionTextWidget == null)
				{
					_descriptionTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descriptionTextWidget", cr2w, this);
				}
				return _descriptionTextWidget;
			}
			set
			{
				if (_descriptionTextWidget == value)
				{
					return;
				}
				_descriptionTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("additionalDataTextWidget")] 
		public inkTextWidgetReference AdditionalDataTextWidget
		{
			get
			{
				if (_additionalDataTextWidget == null)
				{
					_additionalDataTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "additionalDataTextWidget", cr2w, this);
				}
				return _additionalDataTextWidget;
			}
			set
			{
				if (_additionalDataTextWidget == value)
				{
					return;
				}
				_additionalDataTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get
			{
				if (_introAnimationName == null)
				{
					_introAnimationName = (CName) CR2WTypeManager.Create("CName", "introAnimationName", cr2w, this);
				}
				return _introAnimationName;
			}
			set
			{
				if (_introAnimationName == value)
				{
					return;
				}
				_introAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("outroAnimationName")] 
		public CName OutroAnimationName
		{
			get
			{
				if (_outroAnimationName == null)
				{
					_outroAnimationName = (CName) CR2WTypeManager.Create("CName", "outroAnimationName", cr2w, this);
				}
				return _outroAnimationName;
			}
			set
			{
				if (_outroAnimationName == value)
				{
					return;
				}
				_outroAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("confirmButton")] 
		public inkWidgetReference ConfirmButton
		{
			get
			{
				if (_confirmButton == null)
				{
					_confirmButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "confirmButton", cr2w, this);
				}
				return _confirmButton;
			}
			set
			{
				if (_confirmButton == value)
				{
					return;
				}
				_confirmButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cancelButton")] 
		public inkWidgetReference CancelButton
		{
			get
			{
				if (_cancelButton == null)
				{
					_cancelButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cancelButton", cr2w, this);
				}
				return _cancelButton;
			}
			set
			{
				if (_cancelButton == value)
				{
					return;
				}
				_cancelButton = value;
				PropertySet(this);
			}
		}

		public inkGenericSystemNotificationLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
