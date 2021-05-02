using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskCaretakerManagerDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("drainTemplate")] 		public CHandle<CEntityTemplate> DrainTemplate { get; set;}

		[Ordinal(2)] [RED("recoverPercPerHit")] 		public CFloat RecoverPercPerHit { get; set;}

		[Ordinal(3)] [RED("shadesModifier")] 		public CFloat ShadesModifier { get; set;}

		public BTTaskCaretakerManagerDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskCaretakerManagerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}