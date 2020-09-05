using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphNode : CGraphBlock
	{
		[Ordinal(1)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(2)] [RED("color")] 		public CColor Color { get; set;}

		[Ordinal(3)] [RED("activateNotification")] 		public CName ActivateNotification { get; set;}

		[Ordinal(4)] [RED("deactivateNotification")] 		public CName DeactivateNotification { get; set;}

		[Ordinal(5)] [RED("generateEditorFragments")] 		public CBool GenerateEditorFragments { get; set;}

		[Ordinal(6)] [RED("id")] 		public CUInt32 Id { get; set;}

		[Ordinal(7)] [RED("logOnActivation")] 		public CString LogOnActivation { get; set;}

		[Ordinal(8)] [RED("debugCodeId")] 		public CInt32 DebugCodeId { get; set;}

		[Ordinal(9)] [RED("debugCodeBreak_Act")] 		public CBool DebugCodeBreak_Act { get; set;}

		[Ordinal(10)] [RED("debugCodeBreak_Deact")] 		public CBool DebugCodeBreak_Deact { get; set;}

		public CBehaviorGraphNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}