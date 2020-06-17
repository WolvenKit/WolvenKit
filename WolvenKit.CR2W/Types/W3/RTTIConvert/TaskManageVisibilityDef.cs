using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TaskManageVisibilityDef : IBehTreeTaskDefinition
	{
		[RED("visible")] 		public CBool Visible { get; set;}

		[RED("changeMeshVisibility")] 		public CBool ChangeMeshVisibility { get; set;}

		[RED("changeGameplayVisibility")] 		public CBool ChangeGameplayVisibility { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[RED("onAnimEventName")] 		public CName OnAnimEventName { get; set;}

		public TaskManageVisibilityDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new TaskManageVisibilityDef(cr2w);

	}
}