using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceInkLogicControllerBase : inkWidgetLogicController
	{
		private inkWidgetReference _targetWidgetRef;
		private inkTextWidgetReference _displayNameWidget;
		private CBool _isInitialized;
		private wCHandle<inkWidget> _targetWidget;

		[Ordinal(1)] 
		[RED("targetWidgetRef")] 
		public inkWidgetReference TargetWidgetRef
		{
			get
			{
				if (_targetWidgetRef == null)
				{
					_targetWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetWidgetRef", cr2w, this);
				}
				return _targetWidgetRef;
			}
			set
			{
				if (_targetWidgetRef == value)
				{
					return;
				}
				_targetWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("displayNameWidget")] 
		public inkTextWidgetReference DisplayNameWidget
		{
			get
			{
				if (_displayNameWidget == null)
				{
					_displayNameWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "displayNameWidget", cr2w, this);
				}
				return _displayNameWidget;
			}
			set
			{
				if (_displayNameWidget == value)
				{
					return;
				}
				_displayNameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetWidget")] 
		public wCHandle<inkWidget> TargetWidget
		{
			get
			{
				if (_targetWidget == null)
				{
					_targetWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "targetWidget", cr2w, this);
				}
				return _targetWidget;
			}
			set
			{
				if (_targetWidget == value)
				{
					return;
				}
				_targetWidget = value;
				PropertySet(this);
			}
		}

		public DeviceInkLogicControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
