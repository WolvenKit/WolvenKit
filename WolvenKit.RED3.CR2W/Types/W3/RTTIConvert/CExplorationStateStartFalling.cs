using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateStartFalling : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("timeToJump")] 		public CFloat TimeToJump { get; set;}

		[Ordinal(2)] [RED("fallCancelled")] 		public CBool FallCancelled { get; set;}

		[Ordinal(3)] [RED("fallType")] 		public CEnum<EFallType> FallType { get; set;}

		[Ordinal(4)] [RED("behFallType")] 		public CName BehFallType { get; set;}

		[Ordinal(5)] [RED("cameraFallIsSet")] 		public CBool CameraFallIsSet { get; set;}

		[Ordinal(6)] [RED("q704_gravit_shift")] 		public CBool Q704_gravit_shift { get; set;}

		public CExplorationStateStartFalling(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}