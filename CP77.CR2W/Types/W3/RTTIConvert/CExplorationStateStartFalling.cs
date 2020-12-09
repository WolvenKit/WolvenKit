using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
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

		public CExplorationStateStartFalling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateStartFalling(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}