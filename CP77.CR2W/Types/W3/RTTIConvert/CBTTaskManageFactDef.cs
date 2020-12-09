using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageFactDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("fact")] 		public CString Fact { get; set;}

		[Ordinal(2)] [RED("value")] 		public CInt32 Value { get; set;}

		[Ordinal(3)] [RED("add")] 		public CBool Add { get; set;}

		[Ordinal(4)] [RED("validFor")] 		public CInt32 ValidFor { get; set;}

		[Ordinal(5)] [RED("doNotCompleteAfter")] 		public CBool DoNotCompleteAfter { get; set;}

		[Ordinal(6)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(7)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(8)] [RED("eventName")] 		public CName EventName { get; set;}

		public CBTTaskManageFactDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskManageFactDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}