using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTStep : IMoveSteeringTask
	{
		[RED("stepDistanceVar")] 		public CName StepDistanceVar { get; set;}

		[RED("stepHeadingVar")] 		public CName StepHeadingVar { get; set;}

		[RED("stepEvent")] 		public CName StepEvent { get; set;}

		[RED("stepNotification")] 		public CName StepNotification { get; set;}

		public CMoveSTStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTStep(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}