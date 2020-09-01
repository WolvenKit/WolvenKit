using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEncounterCreatureDefinition : CObject
	{
		[Ordinal(1)] [RED("definitionName")] 		public CName DefinitionName { get; set;}

		[Ordinal(2)] [RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(3)] [RED("totalSpawnLimit")] 		public CUInt16 TotalSpawnLimit { get; set;}

		[Ordinal(4)] [RED("maxSpawnedAtOnce")] 		public CUInt16 MaxSpawnedAtOnce { get; set;}

		[Ordinal(5)] [RED("override")] 		public CBool Override { get; set;}

		[Ordinal(6)] [RED("forcedAppearance")] 		public CName ForcedAppearance { get; set;}

		[Ordinal(7)] [RED("tags")] 		public TagList Tags { get; set;}

		public CEncounterCreatureDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEncounterCreatureDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}