using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleGarageComponentVehicleData : CVariable
	{
		[Ordinal(0)] [RED("spawnRecordID")] public TweakDBID SpawnRecordID { get; set; }
		[Ordinal(1)] [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(2)] [RED("vehicleNameNodeRef")] public NodeRef VehicleNameNodeRef { get; set; }

		public vehicleGarageComponentVehicleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
