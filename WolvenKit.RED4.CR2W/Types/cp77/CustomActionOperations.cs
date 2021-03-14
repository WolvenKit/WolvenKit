using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomActionOperations : DeviceOperations
	{
		private SCustomDeviceActionsData _customActions;
		private CArray<SCustomActionOperationData> _customActionsOperations;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("customActionsOperations")] 
		public CArray<SCustomActionOperationData> CustomActionsOperations
		{
			get
			{
				if (_customActionsOperations == null)
				{
					_customActionsOperations = (CArray<SCustomActionOperationData>) CR2WTypeManager.Create("array:SCustomActionOperationData", "customActionsOperations", cr2w, this);
				}
				return _customActionsOperations;
			}
			set
			{
				if (_customActionsOperations == value)
				{
					return;
				}
				_customActionsOperations = value;
				PropertySet(this);
			}
		}

		public CustomActionOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
