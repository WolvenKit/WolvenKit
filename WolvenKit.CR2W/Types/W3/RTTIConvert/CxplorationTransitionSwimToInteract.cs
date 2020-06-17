using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CxplorationTransitionSwimToInteract : CExplorationStateTransitionAbstract
	{
		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("timeToTransition")] 		public CFloat TimeToTransition { get; set;}

		[RED("requireAngle")] 		public CBool RequireAngle { get; set;}

		[RED("timeToStopTrying")] 		public CFloat TimeToStopTrying { get; set;}

		[RED("animEventToBeReady")] 		public CName AnimEventToBeReady { get; set;}

		public CxplorationTransitionSwimToInteract(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CxplorationTransitionSwimToInteract(cr2w);

	}
}