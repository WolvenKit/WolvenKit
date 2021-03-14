using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3VehicleCombatManagerStateCastSign : CScriptableState
	{
		[Ordinal(1)] [RED("witcher")] 		public CHandle<W3PlayerWitcher> Witcher { get; set;}

		[Ordinal(2)] [RED("horse")] 		public CHandle<CActor> Horse { get; set;}

		[Ordinal(3)] [RED("horseComp")] 		public CHandle<W3HorseComponent> HorseComp { get; set;}

		public W3VehicleCombatManagerStateCastSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3VehicleCombatManagerStateCastSign(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}