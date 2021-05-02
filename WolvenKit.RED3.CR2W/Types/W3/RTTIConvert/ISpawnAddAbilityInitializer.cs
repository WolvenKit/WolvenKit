using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ISpawnAddAbilityInitializer : ISpawnTreeScriptedInitializer
	{
		[Ordinal(1)] [RED("remove")] 		public CBool Remove { get; set;}

		[Ordinal(2)] [RED("abulities", 2,0)] 		public CArray<CName> Abulities { get; set;}

		[Ordinal(3)] [RED("abilityName")] 		public CName AbilityName { get; set;}

		[Ordinal(4)] [RED("i")] 		public CInt32 I { get; set;}

		public ISpawnAddAbilityInitializer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}