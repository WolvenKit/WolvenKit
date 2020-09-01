using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMagicMeleeAttack : CBTTaskMagicAttack
	{
		[Ordinal(0)] [RED("("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("("fxOnAnimEvent", 2,0)] 		public CArray<SFxOnAnimEvent> FxOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("effectEntityTemplate")] 		public CHandle<CEntityTemplate> EffectEntityTemplate { get; set;}

		[Ordinal(0)] [RED("("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(0)] [RED("("dealDmgOnDeactivate")] 		public CBool DealDmgOnDeactivate { get; set;}

		[Ordinal(0)] [RED("("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		[Ordinal(0)] [RED("("effectHitName")] 		public CName EffectHitName { get; set;}

		[Ordinal(0)] [RED("("foundPos")] 		public CBool FoundPos { get; set;}

		[Ordinal(0)] [RED("("pos")] 		public Vector Pos { get; set;}

		[Ordinal(0)] [RED("("rot")] 		public EulerAngles Rot { get; set;}

		public CBTTaskMagicMeleeAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMagicMeleeAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}