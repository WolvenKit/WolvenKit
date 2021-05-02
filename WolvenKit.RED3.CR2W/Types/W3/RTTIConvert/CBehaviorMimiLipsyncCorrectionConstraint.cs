using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorMimiLipsyncCorrectionConstraint : IBehaviorMimicConstraint
	{
		[Ordinal(1)] [RED("controlTrack")] 		public CInt32 ControlTrack { get; set;}

		[Ordinal(2)] [RED("trackBegin")] 		public CInt32 TrackBegin { get; set;}

		[Ordinal(3)] [RED("trackEnd")] 		public CInt32 TrackEnd { get; set;}

		public CBehaviorMimiLipsyncCorrectionConstraint(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}