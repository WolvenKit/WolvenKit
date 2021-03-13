using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetAppearance : IBehTreeTask
	{
		[Ordinal(1)] [RED("appearanceName")] 		public CName AppearanceName { get; set;}

		[Ordinal(2)] [RED("previousAppearance")] 		public CName PreviousAppearance { get; set;}

		[Ordinal(3)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(4)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(5)] [RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		[Ordinal(6)] [RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[Ordinal(7)] [RED("overrideForTask")] 		public CBool OverrideForTask { get; set;}

		[Ordinal(8)] [RED("eventName")] 		public CName EventName { get; set;}

		public CBTTaskSetAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetAppearance(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}