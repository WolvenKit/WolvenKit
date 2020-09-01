using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4FinisherDLC : CObject
	{
		[Ordinal(0)] [RED("("finisherAnimName")] 		public CName FinisherAnimName { get; set;}

		[Ordinal(0)] [RED("("woundName")] 		public CName WoundName { get; set;}

		[Ordinal(0)] [RED("("finisherSide")] 		public CEnum<EFinisherSide> FinisherSide { get; set;}

		[Ordinal(0)] [RED("("leftCameraAnimName")] 		public CName LeftCameraAnimName { get; set;}

		[Ordinal(0)] [RED("("rightCameraAnimName")] 		public CName RightCameraAnimName { get; set;}

		[Ordinal(0)] [RED("("frontCameraAnimName")] 		public CName FrontCameraAnimName { get; set;}

		[Ordinal(0)] [RED("("backCameraAnimName")] 		public CName BackCameraAnimName { get; set;}

		public CR4FinisherDLC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4FinisherDLC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}