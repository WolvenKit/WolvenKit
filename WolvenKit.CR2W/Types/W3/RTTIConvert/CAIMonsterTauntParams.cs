using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterTauntParams : CAITauntParameters
	{
		[Ordinal(0)] [RED("stopTauntingDistance")] 		public CFloat StopTauntingDistance { get; set;}

		[Ordinal(0)] [RED("tauntDelay")] 		public CFloat TauntDelay { get; set;}

		[Ordinal(0)] [RED("forceAttackDelay")] 		public CFloat ForceAttackDelay { get; set;}

		[Ordinal(0)] [RED("useSurround")] 		public CBool UseSurround { get; set;}

		[Ordinal(0)] [RED("chanceToMove")] 		public CFloat ChanceToMove { get; set;}

		public CAIMonsterTauntParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterTauntParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}