using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphNode : CGraphBlock
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("activateNotification")] 		public CName ActivateNotification { get; set;}

		[RED("deactivateNotification")] 		public CName DeactivateNotification { get; set;}

		[RED("generateEditorFragments")] 		public CBool GenerateEditorFragments { get; set;}

		[RED("id")] 		public CUInt32 Id { get; set;}

		public CBehaviorGraphNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}