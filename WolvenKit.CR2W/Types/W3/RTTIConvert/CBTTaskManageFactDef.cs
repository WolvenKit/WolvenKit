using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageFactDef : IBehTreeTaskDefinition
	{
		[RED("fact")] 		public CString Fact { get; set;}

		[RED("value")] 		public CInt32 Value { get; set;}

		[RED("add")] 		public CBool Add { get; set;}

		[RED("validFor")] 		public CInt32 ValidFor { get; set;}

		[RED("doNotCompleteAfter")] 		public CBool DoNotCompleteAfter { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[RED("eventName")] 		public CName EventName { get; set;}

		public CBTTaskManageFactDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskManageFactDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}