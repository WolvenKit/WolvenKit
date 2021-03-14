using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceActionsData : CVariable
	{
		private SGenericDeviceActionsData _stateActionsOverrides;
		private SCustomDeviceActionsData _customActions;

		[Ordinal(0)] 
		[RED("stateActionsOverrides")] 
		public SGenericDeviceActionsData StateActionsOverrides
		{
			get
			{
				if (_stateActionsOverrides == null)
				{
					_stateActionsOverrides = (SGenericDeviceActionsData) CR2WTypeManager.Create("SGenericDeviceActionsData", "stateActionsOverrides", cr2w, this);
				}
				return _stateActionsOverrides;
			}
			set
			{
				if (_stateActionsOverrides == value)
				{
					return;
				}
				_stateActionsOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("customActions")] 
		public SCustomDeviceActionsData CustomActions
		{
			get
			{
				if (_customActions == null)
				{
					_customActions = (SCustomDeviceActionsData) CR2WTypeManager.Create("SCustomDeviceActionsData", "customActions", cr2w, this);
				}
				return _customActions;
			}
			set
			{
				if (_customActions == value)
				{
					return;
				}
				_customActions = value;
				PropertySet(this);
			}
		}

		public GenericDeviceActionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
