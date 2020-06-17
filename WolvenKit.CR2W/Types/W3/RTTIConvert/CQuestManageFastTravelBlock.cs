using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestManageFastTravelBlock : CQuestGraphBlock
	{
		[RED("operation")] 		public EQuestManageFastTravelOperation Operation { get; set;}

		[RED("enable")] 		public CBool Enable { get; set;}

		[RED("show")] 		public CBool Show { get; set;}

		[RED("affectedAreas", 2,0)] 		public CArray<CInt32> AffectedAreas { get; set;}

		[RED("affectedFastTravelPoints", 2,0)] 		public CArray<CName> AffectedFastTravelPoints { get; set;}

		public CQuestManageFastTravelBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestManageFastTravelBlock(cr2w);

	}
}