using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardDefaultPoseInfo : CVariable
	{
		[RED("uId")] 		public CInt32 UId { get; set;}

		[RED("type")] 		public CInt32 Type { get; set;}

		[RED("animId")] 		public CName AnimId { get; set;}

		public SStoryBoardDefaultPoseInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SStoryBoardDefaultPoseInfo(cr2w);

	}
}