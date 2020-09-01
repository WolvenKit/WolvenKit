using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TaskManageCapsuleCollision : IBehTreeTask
	{
		[Ordinal(0)] [RED("("collision")] 		public CBool Collision { get; set;}

		[Ordinal(0)] [RED("("allCollisionTypes")] 		public CBool AllCollisionTypes { get; set;}

		[Ordinal(0)] [RED("("overrideForThisTaskOnly")] 		public CBool OverrideForThisTaskOnly { get; set;}

		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("switchVulnerability")] 		public CBool SwitchVulnerability { get; set;}

		[Ordinal(0)] [RED("("effectLinkedToCollision")] 		public CName EffectLinkedToCollision { get; set;}

		public TaskManageCapsuleCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TaskManageCapsuleCollision(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}