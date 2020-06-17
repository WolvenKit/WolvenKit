using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetAppearanceDef : IBehTreeTaskDefinition
	{
		[RED("appearanceName")] 		public CName AppearanceName { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		[RED("onAnimEvent")] 		public CBool OnAnimEvent { get; set;}

		[RED("overrideForTask")] 		public CBool OverrideForTask { get; set;}

		[RED("eventName")] 		public CName EventName { get; set;}

		public CBTTaskSetAppearanceDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSetAppearanceDef(cr2w);

	}
}