using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TaskManageVisibilityDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("visible")] 		public CBool Visible { get; set;}

		[Ordinal(0)] [RED("("changeMeshVisibility")] 		public CBool ChangeMeshVisibility { get; set;}

		[Ordinal(0)] [RED("("changeGameplayVisibility")] 		public CBool ChangeGameplayVisibility { get; set;}

		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("onAnimEventName")] 		public CName OnAnimEventName { get; set;}

		public TaskManageVisibilityDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TaskManageVisibilityDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}