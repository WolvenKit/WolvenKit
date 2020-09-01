using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetAppearanceDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("("appearanceName")] 		public CName AppearanceName { get; set;}

		[Ordinal(2)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(3)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(4)] [RED("("onSuccess")] 		public CBool OnSuccess { get; set;}

		[Ordinal(5)] [RED("("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(6)] [RED("("overrideForTask")] 		public CBool OverrideForTask { get; set;}

		[Ordinal(7)] [RED("("eventName")] 		public CName EventName { get; set;}

		public CBTTaskSetAppearanceDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetAppearanceDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}