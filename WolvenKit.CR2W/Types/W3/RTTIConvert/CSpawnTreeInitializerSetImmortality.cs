using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeInitializerSetImmortality : ISpawnTreeScriptedInitializer
	{
		[Ordinal(1)] [RED("immortalityMode")] 		public CEnum<EActorImmortalityMode> ImmortalityMode { get; set;}

		[Ordinal(2)] [RED("previousImmortalityMode")] 		public CEnum<EActorImmortalityMode> PreviousImmortalityMode { get; set;}

		public CSpawnTreeInitializerSetImmortality(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnTreeInitializerSetImmortality(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}