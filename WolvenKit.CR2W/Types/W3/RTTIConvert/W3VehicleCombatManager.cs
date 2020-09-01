using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3VehicleCombatManager : CEntity
	{
		[Ordinal(1)] [RED("("rider")] 		public CHandle<CR4Player> Rider { get; set;}

		[Ordinal(2)] [RED("("vehicle")] 		public CHandle<CVehicleComponent> Vehicle { get; set;}

		[Ordinal(3)] [RED("("isInCombatAction")] 		public CBool IsInCombatAction { get; set;}

		[Ordinal(4)] [RED("("wasBombReleased")] 		public CBool WasBombReleased { get; set;}

		public W3VehicleCombatManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3VehicleCombatManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}