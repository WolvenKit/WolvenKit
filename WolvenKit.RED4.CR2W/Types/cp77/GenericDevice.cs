using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericDevice : InteractiveDevice
	{
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionComponent;
		private CHandle<CustomDeviceAction> _currentSpiderbotAction;

		[Ordinal(93)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get
			{
				if (_offMeshConnectionComponent == null)
				{
					_offMeshConnectionComponent = (CHandle<AIOffMeshConnectionComponent>) CR2WTypeManager.Create("handle:AIOffMeshConnectionComponent", "offMeshConnectionComponent", cr2w, this);
				}
				return _offMeshConnectionComponent;
			}
			set
			{
				if (_offMeshConnectionComponent == value)
				{
					return;
				}
				_offMeshConnectionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("currentSpiderbotAction")] 
		public CHandle<CustomDeviceAction> CurrentSpiderbotAction
		{
			get
			{
				if (_currentSpiderbotAction == null)
				{
					_currentSpiderbotAction = (CHandle<CustomDeviceAction>) CR2WTypeManager.Create("handle:CustomDeviceAction", "currentSpiderbotAction", cr2w, this);
				}
				return _currentSpiderbotAction;
			}
			set
			{
				if (_currentSpiderbotAction == value)
				{
					return;
				}
				_currentSpiderbotAction = value;
				PropertySet(this);
			}
		}

		public GenericDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
