using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMagicFXAttack : CBTTaskMagicAttack
	{
		[Ordinal(0)] [RED("("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("("effectEntityTemplate")] 		public CHandle<CEntityTemplate> EffectEntityTemplate { get; set;}

		[Ordinal(0)] [RED("("dealDmgOnDeactivate")] 		public CBool DealDmgOnDeactivate { get; set;}

		[Ordinal(0)] [RED("("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		public CBTTaskMagicFXAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMagicFXAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}