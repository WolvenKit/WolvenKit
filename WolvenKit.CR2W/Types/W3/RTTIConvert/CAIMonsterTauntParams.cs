using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterTauntParams : CAITauntParameters
	{
		[RED("stopTauntingDistance")] 		public CFloat StopTauntingDistance { get; set;}

		[RED("tauntDelay")] 		public CFloat TauntDelay { get; set;}

		[RED("forceAttackDelay")] 		public CFloat ForceAttackDelay { get; set;}

		[RED("useSurround")] 		public CBool UseSurround { get; set;}

		[RED("chanceToMove")] 		public CFloat ChanceToMove { get; set;}

		public CAIMonsterTauntParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIMonsterTauntParams(cr2w);

	}
}