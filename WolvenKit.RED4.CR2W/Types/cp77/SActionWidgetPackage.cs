using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SActionWidgetPackage : SWidgetPackage
	{
		private CHandle<gamedeviceAction> _action;
		private CBool _wasInitalized;
		private CArray<CHandle<gamedeviceAction>> _dependendActions;

		[Ordinal(17)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<gamedeviceAction>) CR2WTypeManager.Create("handle:gamedeviceAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("wasInitalized")] 
		public CBool WasInitalized
		{
			get
			{
				if (_wasInitalized == null)
				{
					_wasInitalized = (CBool) CR2WTypeManager.Create("Bool", "wasInitalized", cr2w, this);
				}
				return _wasInitalized;
			}
			set
			{
				if (_wasInitalized == value)
				{
					return;
				}
				_wasInitalized = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("dependendActions")] 
		public CArray<CHandle<gamedeviceAction>> DependendActions
		{
			get
			{
				if (_dependendActions == null)
				{
					_dependendActions = (CArray<CHandle<gamedeviceAction>>) CR2WTypeManager.Create("array:handle:gamedeviceAction", "dependendActions", cr2w, this);
				}
				return _dependendActions;
			}
			set
			{
				if (_dependendActions == value)
				{
					return;
				}
				_dependendActions = value;
				PropertySet(this);
			}
		}

		public SActionWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
