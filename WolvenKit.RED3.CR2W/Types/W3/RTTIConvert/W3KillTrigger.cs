using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3KillTrigger : CEntity
	{
		[Ordinal(1)] [RED("postponedTillOnGroundMPAC", 2,0)] 		public CArray<CHandle<CMovingPhysicalAgentComponent>> PostponedTillOnGroundMPAC { get; set;}

		[Ordinal(2)] [RED("postponeTillOnGround")] 		public CBool PostponeTillOnGround { get; set;}

		[Ordinal(3)] [RED("postponeTillStoppedFalling")] 		public CBool PostponeTillStoppedFalling { get; set;}

		[Ordinal(4)] [RED("postponeTillinWater")] 		public CBool PostponeTillinWater { get; set;}

		public W3KillTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3KillTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}