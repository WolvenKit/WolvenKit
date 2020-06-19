using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestManageFastTravelBlock : CQuestGraphBlock
	{
		[RED("operation")] 		public CEnum<EQuestManageFastTravelOperation> Operation { get; set;}

		[RED("enable")] 		public CBool Enable { get; set;}

		[RED("show")] 		public CBool Show { get; set;}

		[RED("affectedAreas", 2,0)] 		public CArray<CInt32> AffectedAreas { get; set;}

		[RED("affectedFastTravelPoints", 2,0)] 		public CArray<CName> AffectedFastTravelPoints { get; set;}

		public CQuestManageFastTravelBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestManageFastTravelBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}