using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorMimiLipsyncCorrectionConstraint : IBehaviorMimicConstraint
	{
		[RED("controlTrack")] 		public CInt32 ControlTrack { get; set;}

		[RED("trackBegin")] 		public CInt32 TrackBegin { get; set;}

		[RED("trackEnd")] 		public CInt32 TrackEnd { get; set;}

		public CBehaviorMimiLipsyncCorrectionConstraint(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorMimiLipsyncCorrectionConstraint(cr2w);

	}
}