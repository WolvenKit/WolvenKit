using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayDefaultMountedSlotWorkspotEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private gameEntityReference _parentRef;
		private CName _slotName;
		private CEnum<scnPuppetVehicleState> _puppetVehicleState;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get
			{
				if (_performer == null)
				{
					_performer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performer", cr2w, this);
				}
				return _performer;
			}
			set
			{
				if (_performer == value)
				{
					return;
				}
				_performer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get
			{
				if (_parentRef == null)
				{
					_parentRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "parentRef", cr2w, this);
				}
				return _parentRef;
			}
			set
			{
				if (_parentRef == value)
				{
					return;
				}
				_parentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("puppetVehicleState")] 
		public CEnum<scnPuppetVehicleState> PuppetVehicleState
		{
			get
			{
				if (_puppetVehicleState == null)
				{
					_puppetVehicleState = (CEnum<scnPuppetVehicleState>) CR2WTypeManager.Create("scnPuppetVehicleState", "puppetVehicleState", cr2w, this);
				}
				return _puppetVehicleState;
			}
			set
			{
				if (_puppetVehicleState == value)
				{
					return;
				}
				_puppetVehicleState = value;
				PropertySet(this);
			}
		}

		public scnPlayDefaultMountedSlotWorkspotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
