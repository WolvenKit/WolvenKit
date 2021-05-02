using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskForceHitReaction : IBehTreeTask
	{
		[Ordinal(1)] [RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(2)] [RED("hitReactionSide")] 		public CEnum<EHitReactionSide> HitReactionSide { get; set;}

		[Ordinal(3)] [RED("hitReactionDirection")] 		public CEnum<EHitReactionDirection> HitReactionDirection { get; set;}

		[Ordinal(4)] [RED("hitSwingType")] 		public CEnum<EAttackSwingType> HitSwingType { get; set;}

		[Ordinal(5)] [RED("hitSwingDirection")] 		public CEnum<EAttackSwingDirection> HitSwingDirection { get; set;}

		public BTTaskForceHitReaction(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskForceHitReaction(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}