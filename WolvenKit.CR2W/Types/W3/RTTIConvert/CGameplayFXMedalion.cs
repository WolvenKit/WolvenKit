using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameplayFXMedalion : CEntity
	{
		[RED("beginRadius")] 		public CFloat BeginRadius { get; set;}

		[RED("endRadius")] 		public CFloat EndRadius { get; set;}

		[RED("ringRadiusTolerance")] 		public CFloat RingRadiusTolerance { get; set;}

		[RED("debugLoop")] 		public CBool DebugLoop { get; set;}

		[RED("distPerSec")] 		public CFloat DistPerSec { get; set;}

		[RED("sustainTime")] 		public CFloat SustainTime { get; set;}

		[RED("highlightTag")] 		public CName HighlightTag { get; set;}

		public CGameplayFXMedalion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameplayFXMedalion(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}