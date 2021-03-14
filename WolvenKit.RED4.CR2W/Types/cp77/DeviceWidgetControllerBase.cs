using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceWidgetControllerBase : DeviceInkLogicControllerBase
	{
		private inkImageWidgetReference _backgroundTextureRef;
		private inkTextWidgetReference _statusNameWidget;
		private inkWidgetReference _actionsListWidget;
		private CArray<SActionWidgetPackage> _actionWidgetsData;
		private CHandle<ResolveActionData> _actionData;

		[Ordinal(5)] 
		[RED("backgroundTextureRef")] 
		public inkImageWidgetReference BackgroundTextureRef
		{
			get
			{
				if (_backgroundTextureRef == null)
				{
					_backgroundTextureRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "backgroundTextureRef", cr2w, this);
				}
				return _backgroundTextureRef;
			}
			set
			{
				if (_backgroundTextureRef == value)
				{
					return;
				}
				_backgroundTextureRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("statusNameWidget")] 
		public inkTextWidgetReference StatusNameWidget
		{
			get
			{
				if (_statusNameWidget == null)
				{
					_statusNameWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "statusNameWidget", cr2w, this);
				}
				return _statusNameWidget;
			}
			set
			{
				if (_statusNameWidget == value)
				{
					return;
				}
				_statusNameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("actionsListWidget")] 
		public inkWidgetReference ActionsListWidget
		{
			get
			{
				if (_actionsListWidget == null)
				{
					_actionsListWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "actionsListWidget", cr2w, this);
				}
				return _actionsListWidget;
			}
			set
			{
				if (_actionsListWidget == value)
				{
					return;
				}
				_actionsListWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("actionWidgetsData")] 
		public CArray<SActionWidgetPackage> ActionWidgetsData
		{
			get
			{
				if (_actionWidgetsData == null)
				{
					_actionWidgetsData = (CArray<SActionWidgetPackage>) CR2WTypeManager.Create("array:SActionWidgetPackage", "actionWidgetsData", cr2w, this);
				}
				return _actionWidgetsData;
			}
			set
			{
				if (_actionWidgetsData == value)
				{
					return;
				}
				_actionWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("actionData")] 
		public CHandle<ResolveActionData> ActionData
		{
			get
			{
				if (_actionData == null)
				{
					_actionData = (CHandle<ResolveActionData>) CR2WTypeManager.Create("handle:ResolveActionData", "actionData", cr2w, this);
				}
				return _actionData;
			}
			set
			{
				if (_actionData == value)
				{
					return;
				}
				_actionData = value;
				PropertySet(this);
			}
		}

		public DeviceWidgetControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
