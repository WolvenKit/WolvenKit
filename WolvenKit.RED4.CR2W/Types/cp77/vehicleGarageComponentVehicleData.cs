using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleGarageComponentVehicleData : CVariable
	{
		private TweakDBID _spawnRecordID;
		private entEntityID _entityID;
		private NodeRef _vehicleNameNodeRef;

		[Ordinal(0)] 
		[RED("spawnRecordID")] 
		public TweakDBID SpawnRecordID
		{
			get
			{
				if (_spawnRecordID == null)
				{
					_spawnRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "spawnRecordID", cr2w, this);
				}
				return _spawnRecordID;
			}
			set
			{
				if (_spawnRecordID == value)
				{
					return;
				}
				_spawnRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vehicleNameNodeRef")] 
		public NodeRef VehicleNameNodeRef
		{
			get
			{
				if (_vehicleNameNodeRef == null)
				{
					_vehicleNameNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "vehicleNameNodeRef", cr2w, this);
				}
				return _vehicleNameNodeRef;
			}
			set
			{
				if (_vehicleNameNodeRef == value)
				{
					return;
				}
				_vehicleNameNodeRef = value;
				PropertySet(this);
			}
		}

		public vehicleGarageComponentVehicleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
