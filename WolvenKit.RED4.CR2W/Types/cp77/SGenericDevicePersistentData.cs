using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SGenericDevicePersistentData : CVariable
	{
		private SGenericDeviceActionsData _genericActions;
		private SCustomDeviceActionsData _customActions;

		[Ordinal(0)] 
		[RED("genericActions")] 
		public SGenericDeviceActionsData GenericActions
		{
			get
			{
				if (_genericActions == null)
				{
					_genericActions = (SGenericDeviceActionsData) CR2WTypeManager.Create("SGenericDeviceActionsData", "genericActions", cr2w, this);
				}
				return _genericActions;
			}
			set
			{
				if (_genericActions == value)
				{
					return;
				}
				_genericActions = value;
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

		public SGenericDevicePersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
