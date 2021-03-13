using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestManageFastTravelBlock : CQuestGraphBlock
	{
		[Ordinal(1)] [RED("operation")] 		public CEnum<EQuestManageFastTravelOperation> Operation { get; set;}

		[Ordinal(2)] [RED("enable")] 		public CBool Enable { get; set;}

		[Ordinal(3)] [RED("show")] 		public CBool Show { get; set;}

		[Ordinal(4)] [RED("affectedAreas", 2,0)] 		public CArray<CInt32> AffectedAreas { get; set;}

		[Ordinal(5)] [RED("affectedFastTravelPoints", 2,0)] 		public CArray<CName> AffectedFastTravelPoints { get; set;}

		public CQuestManageFastTravelBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestManageFastTravelBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}