using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskLeshyBirdAttack : CBTTaskSwarm
	{
		[RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[RED("attackRange")] 		public CFloat AttackRange { get; set;}

		[RED("time")] 		public CFloat Time { get; set;}

		[RED("startingTime")] 		public CFloat StartingTime { get; set;}

		[RED("attackGroupID")] 		public CFlyingGroupId AttackGroupID { get; set;}

		[RED("activeSwarm")] 		public CBool ActiveSwarm { get; set;}

		[RED("projEntity")] 		public CHandle<CEntityTemplate> ProjEntity { get; set;}

		[RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		public CBTTaskLeshyBirdAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskLeshyBirdAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}