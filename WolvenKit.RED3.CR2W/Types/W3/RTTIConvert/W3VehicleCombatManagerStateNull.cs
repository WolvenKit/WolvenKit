using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3VehicleCombatManagerStateNull : CScriptableState
	{
		[Ordinal(1)] [RED("rider")] 		public CHandle<CR4Player> Rider { get; set;}

		[Ordinal(2)] [RED("horseComp")] 		public CHandle<W3HorseComponent> HorseComp { get; set;}

		public W3VehicleCombatManagerStateNull(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3VehicleCombatManagerStateNull(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}