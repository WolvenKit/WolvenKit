using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DisarmClue : W3MonsterClue
	{
		[Ordinal(1)] [RED("connectedTripwireTag")] 		public CName ConnectedTripwireTag { get; set;}

		[Ordinal(2)] [RED("connectedTripwire")] 		public CHandle<W3TripwireSwitch> ConnectedTripwire { get; set;}

		public W3DisarmClue(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}