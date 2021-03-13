using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameplayFXMedalion : CEntity
	{
		[Ordinal(1)] [RED("beginRadius")] 		public CFloat BeginRadius { get; set;}

		[Ordinal(2)] [RED("endRadius")] 		public CFloat EndRadius { get; set;}

		[Ordinal(3)] [RED("ringRadiusTolerance")] 		public CFloat RingRadiusTolerance { get; set;}

		[Ordinal(4)] [RED("debugLoop")] 		public CBool DebugLoop { get; set;}

		[Ordinal(5)] [RED("distPerSec")] 		public CFloat DistPerSec { get; set;}

		[Ordinal(6)] [RED("sustainTime")] 		public CFloat SustainTime { get; set;}

		[Ordinal(7)] [RED("highlightTag")] 		public CName HighlightTag { get; set;}

		public CGameplayFXMedalion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameplayFXMedalion(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}