using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CaptionImageIconsLogicController : inkWidgetLogicController
	{
		private inkImageWidgetReference _lifeIcon;
		private inkImageWidgetReference _checkIcon;
		private inkImageWidgetReference _genericIcon;
		private inkImageWidgetReference _payIcon;
		private inkCompoundWidgetReference _lifeHolder;
		private inkCompoundWidgetReference _checkHolder;
		private inkCompoundWidgetReference _genericHolder;
		private inkCompoundWidgetReference _payHolder;
		private inkTextWidgetReference _lifeDescriptionText;
		private inkTextWidgetReference _checkText;
		private inkTextWidgetReference _payText;
		private inkWidgetReference _lifeBackground;
		private inkWidgetReference _lifeBackgroundFail;
		private inkWidgetReference _checkBackground;
		private inkWidgetReference _checkBackgroundFail;
		private inkWidgetReference _payBackground;
		private inkWidgetReference _payBackgroundFail;

		[Ordinal(1)] 
		[RED("LifeIcon")] 
		public inkImageWidgetReference LifeIcon
		{
			get
			{
				if (_lifeIcon == null)
				{
					_lifeIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "LifeIcon", cr2w, this);
				}
				return _lifeIcon;
			}
			set
			{
				if (_lifeIcon == value)
				{
					return;
				}
				_lifeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("CheckIcon")] 
		public inkImageWidgetReference CheckIcon
		{
			get
			{
				if (_checkIcon == null)
				{
					_checkIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "CheckIcon", cr2w, this);
				}
				return _checkIcon;
			}
			set
			{
				if (_checkIcon == value)
				{
					return;
				}
				_checkIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("GenericIcon")] 
		public inkImageWidgetReference GenericIcon
		{
			get
			{
				if (_genericIcon == null)
				{
					_genericIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "GenericIcon", cr2w, this);
				}
				return _genericIcon;
			}
			set
			{
				if (_genericIcon == value)
				{
					return;
				}
				_genericIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("PayIcon")] 
		public inkImageWidgetReference PayIcon
		{
			get
			{
				if (_payIcon == null)
				{
					_payIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "PayIcon", cr2w, this);
				}
				return _payIcon;
			}
			set
			{
				if (_payIcon == value)
				{
					return;
				}
				_payIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("LifeHolder")] 
		public inkCompoundWidgetReference LifeHolder
		{
			get
			{
				if (_lifeHolder == null)
				{
					_lifeHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "LifeHolder", cr2w, this);
				}
				return _lifeHolder;
			}
			set
			{
				if (_lifeHolder == value)
				{
					return;
				}
				_lifeHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("CheckHolder")] 
		public inkCompoundWidgetReference CheckHolder
		{
			get
			{
				if (_checkHolder == null)
				{
					_checkHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CheckHolder", cr2w, this);
				}
				return _checkHolder;
			}
			set
			{
				if (_checkHolder == value)
				{
					return;
				}
				_checkHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("GenericHolder")] 
		public inkCompoundWidgetReference GenericHolder
		{
			get
			{
				if (_genericHolder == null)
				{
					_genericHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "GenericHolder", cr2w, this);
				}
				return _genericHolder;
			}
			set
			{
				if (_genericHolder == value)
				{
					return;
				}
				_genericHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("PayHolder")] 
		public inkCompoundWidgetReference PayHolder
		{
			get
			{
				if (_payHolder == null)
				{
					_payHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "PayHolder", cr2w, this);
				}
				return _payHolder;
			}
			set
			{
				if (_payHolder == value)
				{
					return;
				}
				_payHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("LifeDescriptionText")] 
		public inkTextWidgetReference LifeDescriptionText
		{
			get
			{
				if (_lifeDescriptionText == null)
				{
					_lifeDescriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "LifeDescriptionText", cr2w, this);
				}
				return _lifeDescriptionText;
			}
			set
			{
				if (_lifeDescriptionText == value)
				{
					return;
				}
				_lifeDescriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("CheckText")] 
		public inkTextWidgetReference CheckText
		{
			get
			{
				if (_checkText == null)
				{
					_checkText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CheckText", cr2w, this);
				}
				return _checkText;
			}
			set
			{
				if (_checkText == value)
				{
					return;
				}
				_checkText = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("PayText")] 
		public inkTextWidgetReference PayText
		{
			get
			{
				if (_payText == null)
				{
					_payText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "PayText", cr2w, this);
				}
				return _payText;
			}
			set
			{
				if (_payText == value)
				{
					return;
				}
				_payText = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("LifeBackground")] 
		public inkWidgetReference LifeBackground
		{
			get
			{
				if (_lifeBackground == null)
				{
					_lifeBackground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "LifeBackground", cr2w, this);
				}
				return _lifeBackground;
			}
			set
			{
				if (_lifeBackground == value)
				{
					return;
				}
				_lifeBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("LifeBackgroundFail")] 
		public inkWidgetReference LifeBackgroundFail
		{
			get
			{
				if (_lifeBackgroundFail == null)
				{
					_lifeBackgroundFail = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "LifeBackgroundFail", cr2w, this);
				}
				return _lifeBackgroundFail;
			}
			set
			{
				if (_lifeBackgroundFail == value)
				{
					return;
				}
				_lifeBackgroundFail = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("CheckBackground")] 
		public inkWidgetReference CheckBackground
		{
			get
			{
				if (_checkBackground == null)
				{
					_checkBackground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "CheckBackground", cr2w, this);
				}
				return _checkBackground;
			}
			set
			{
				if (_checkBackground == value)
				{
					return;
				}
				_checkBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("CheckBackgroundFail")] 
		public inkWidgetReference CheckBackgroundFail
		{
			get
			{
				if (_checkBackgroundFail == null)
				{
					_checkBackgroundFail = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "CheckBackgroundFail", cr2w, this);
				}
				return _checkBackgroundFail;
			}
			set
			{
				if (_checkBackgroundFail == value)
				{
					return;
				}
				_checkBackgroundFail = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("PayBackground")] 
		public inkWidgetReference PayBackground
		{
			get
			{
				if (_payBackground == null)
				{
					_payBackground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "PayBackground", cr2w, this);
				}
				return _payBackground;
			}
			set
			{
				if (_payBackground == value)
				{
					return;
				}
				_payBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("PayBackgroundFail")] 
		public inkWidgetReference PayBackgroundFail
		{
			get
			{
				if (_payBackgroundFail == null)
				{
					_payBackgroundFail = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "PayBackgroundFail", cr2w, this);
				}
				return _payBackgroundFail;
			}
			set
			{
				if (_payBackgroundFail == value)
				{
					return;
				}
				_payBackgroundFail = value;
				PropertySet(this);
			}
		}

		public CaptionImageIconsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
