using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NextPreviousActionWidgetController : DeviceActionWidgetControllerBase
	{
		private inkWidgetReference _defaultContainer;
		private inkWidgetReference _declineContainer;
		private CName _moneyStatusAnimName;
		private CBool _isProcessing;

		[Ordinal(28)] 
		[RED("defaultContainer")] 
		public inkWidgetReference DefaultContainer
		{
			get
			{
				if (_defaultContainer == null)
				{
					_defaultContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "defaultContainer", cr2w, this);
				}
				return _defaultContainer;
			}
			set
			{
				if (_defaultContainer == value)
				{
					return;
				}
				_defaultContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("declineContainer")] 
		public inkWidgetReference DeclineContainer
		{
			get
			{
				if (_declineContainer == null)
				{
					_declineContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "declineContainer", cr2w, this);
				}
				return _declineContainer;
			}
			set
			{
				if (_declineContainer == value)
				{
					return;
				}
				_declineContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("moneyStatusAnimName")] 
		public CName MoneyStatusAnimName
		{
			get
			{
				if (_moneyStatusAnimName == null)
				{
					_moneyStatusAnimName = (CName) CR2WTypeManager.Create("CName", "moneyStatusAnimName", cr2w, this);
				}
				return _moneyStatusAnimName;
			}
			set
			{
				if (_moneyStatusAnimName == value)
				{
					return;
				}
				_moneyStatusAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("isProcessing")] 
		public CBool IsProcessing
		{
			get
			{
				if (_isProcessing == null)
				{
					_isProcessing = (CBool) CR2WTypeManager.Create("Bool", "isProcessing", cr2w, this);
				}
				return _isProcessing;
			}
			set
			{
				if (_isProcessing == value)
				{
					return;
				}
				_isProcessing = value;
				PropertySet(this);
			}
		}

		public NextPreviousActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
