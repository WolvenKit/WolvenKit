using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskLeshyBirdAttack : CBTTaskSwarm
	{
		[Ordinal(1)] [RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[Ordinal(2)] [RED("attackRange")] 		public CFloat AttackRange { get; set;}

		[Ordinal(3)] [RED("time")] 		public CFloat Time { get; set;}

		[Ordinal(4)] [RED("startingTime")] 		public CFloat StartingTime { get; set;}

		[Ordinal(5)] [RED("attackGroupID")] 		public CFlyingGroupId AttackGroupID { get; set;}

		[Ordinal(6)] [RED("activeSwarm")] 		public CBool ActiveSwarm { get; set;}

		[Ordinal(7)] [RED("projEntity")] 		public CHandle<CEntityTemplate> ProjEntity { get; set;}

		[Ordinal(8)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(9)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		public CBTTaskLeshyBirdAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskLeshyBirdAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}