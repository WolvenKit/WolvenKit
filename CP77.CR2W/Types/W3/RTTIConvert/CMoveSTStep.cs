using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTStep : IMoveSteeringTask
	{
		[Ordinal(1)] [RED("stepDistanceVar")] 		public CName StepDistanceVar { get; set;}

		[Ordinal(2)] [RED("stepHeadingVar")] 		public CName StepHeadingVar { get; set;}

		[Ordinal(3)] [RED("stepEvent")] 		public CName StepEvent { get; set;}

		[Ordinal(4)] [RED("stepNotification")] 		public CName StepNotification { get; set;}

		public CMoveSTStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTStep(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}