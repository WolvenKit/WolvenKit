using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleGarageComponentVehicleData : CVariable
	{
		[Ordinal(0)]  [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(1)]  [RED("spawnRecordID")] public TweakDBID SpawnRecordID { get; set; }
		[Ordinal(2)]  [RED("vehicleNameNodeRef")] public NodeRef VehicleNameNodeRef { get; set; }

		public vehicleGarageComponentVehicleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
