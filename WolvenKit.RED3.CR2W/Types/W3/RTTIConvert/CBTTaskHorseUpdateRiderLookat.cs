using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHorseUpdateRiderLookat : IBehTreeTask
	{
		[Ordinal(1)] [RED("rider")] 		public CHandle<CActor> Rider { get; set;}

		[Ordinal(2)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(3)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(4)] [RED("useCustomTarget")] 		public CBool UseCustomTarget { get; set;}

		public CBTTaskHorseUpdateRiderLookat(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskHorseUpdateRiderLookat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}