using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMagicMeleeAttack : CBTTaskMagicAttack
	{
		[Ordinal(1)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(2)] [RED("fxOnAnimEvent", 2,0)] 		public CArray<SFxOnAnimEvent> FxOnAnimEvent { get; set;}

		[Ordinal(3)] [RED("effectEntityTemplate")] 		public CHandle<CEntityTemplate> EffectEntityTemplate { get; set;}

		[Ordinal(4)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(5)] [RED("dealDmgOnDeactivate")] 		public CBool DealDmgOnDeactivate { get; set;}

		[Ordinal(6)] [RED("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		[Ordinal(7)] [RED("effectHitName")] 		public CName EffectHitName { get; set;}

		[Ordinal(8)] [RED("foundPos")] 		public CBool FoundPos { get; set;}

		[Ordinal(9)] [RED("pos")] 		public Vector Pos { get; set;}

		[Ordinal(10)] [RED("rot")] 		public EulerAngles Rot { get; set;}

		public CBTTaskMagicMeleeAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMagicMeleeAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}