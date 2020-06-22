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
		[RED("finisherAnimName")] 		public CName FinisherAnimName { get; set;}

		[RED("woundName")] 		public CName WoundName { get; set;}

		[RED("finisherSide")] 		public CEnum<EFinisherSide> FinisherSide { get; set;}

		[RED("leftCameraAnimName")] 		public CName LeftCameraAnimName { get; set;}

		[RED("rightCameraAnimName")] 		public CName RightCameraAnimName { get; set;}

		[RED("frontCameraAnimName")] 		public CName FrontCameraAnimName { get; set;}

		[RED("backCameraAnimName")] 		public CName BackCameraAnimName { get; set;}

		public CR4FinisherDLC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4FinisherDLC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}