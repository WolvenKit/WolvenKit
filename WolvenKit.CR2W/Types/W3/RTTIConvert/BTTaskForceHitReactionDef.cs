using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskForceHitReactionDef : IBehTreeTaskDefinition
	{
		[RED("hitReactionType")] 		public CHandle<CBTEnumHitReactionType> HitReactionType { get; set;}

		[RED("hitReactionSide")] 		public CHandle<CBTEnumHitReactionSide> HitReactionSide { get; set;}

		[RED("hitReactionDirection")] 		public CHandle<CBTEnumHitReactionDirection> HitReactionDirection { get; set;}

		[RED("hitSwingType")] 		public CHandle<CBTEnumAttackSwingType> HitSwingType { get; set;}

		[RED("hitSwingDirection")] 		public CHandle<CBTEnumAttackSwingDriection> HitSwingDirection { get; set;}

		public BTTaskForceHitReactionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskForceHitReactionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}