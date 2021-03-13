using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TaskManageCapsuleCollisionDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("collision")] 		public CBool Collision { get; set;}

		[Ordinal(2)] [RED("allCollisionTypes")] 		public CBool AllCollisionTypes { get; set;}

		[Ordinal(3)] [RED("overrideForThisTaskOnly")] 		public CBool OverrideForThisTaskOnly { get; set;}

		[Ordinal(4)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(5)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(6)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(7)] [RED("switchVulnerability")] 		public CBool SwitchVulnerability { get; set;}

		[Ordinal(8)] [RED("effectLinkedToCollision")] 		public CName EffectLinkedToCollision { get; set;}

		public TaskManageCapsuleCollisionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TaskManageCapsuleCollisionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}