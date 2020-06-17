using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStatePushed : CExplorationStateAbstract
	{
		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("extraTurnAngle")] 		public CFloat ExtraTurnAngle { get; set;}

		[RED("behCanEnd")] 		public CName BehCanEnd { get; set;}

		[RED("behSide")] 		public CName BehSide { get; set;}

		[RED("safetyEndTimeMax")] 		public CFloat SafetyEndTimeMax { get; set;}

		[RED("recheckTimeMin")] 		public CFloat RecheckTimeMin { get; set;}

		public CExplorationStatePushed(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStatePushed(cr2w);

	}
}