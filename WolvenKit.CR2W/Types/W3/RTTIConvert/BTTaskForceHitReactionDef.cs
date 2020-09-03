using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskForceHitReactionDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("hitReactionType")] 		public CHandle<CBTEnumHitReactionType> HitReactionType { get; set;}

		[Ordinal(2)] [RED("hitReactionSide")] 		public CHandle<CBTEnumHitReactionSide> HitReactionSide { get; set;}

		[Ordinal(3)] [RED("hitReactionDirection")] 		public CHandle<CBTEnumHitReactionDirection> HitReactionDirection { get; set;}

		[Ordinal(4)] [RED("hitSwingType")] 		public CHandle<CBTEnumAttackSwingType> HitSwingType { get; set;}

		[Ordinal(5)] [RED("hitSwingDirection")] 		public CHandle<CBTEnumAttackSwingDriection> HitSwingDirection { get; set;}

		public BTTaskForceHitReactionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskForceHitReactionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}