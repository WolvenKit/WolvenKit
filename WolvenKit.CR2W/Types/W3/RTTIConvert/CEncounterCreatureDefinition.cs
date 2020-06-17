using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEncounterCreatureDefinition : CObject
	{
		[RED("definitionName")] 		public CName DefinitionName { get; set;}

		[RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[RED("totalSpawnLimit")] 		public CUInt16 TotalSpawnLimit { get; set;}

		[RED("maxSpawnedAtOnce")] 		public CUInt16 MaxSpawnedAtOnce { get; set;}

		[RED("override")] 		public CBool Override { get; set;}

		[RED("forcedAppearance")] 		public CName ForcedAppearance { get; set;}

		[RED("tags")] 		public TagList Tags { get; set;}

		public CEncounterCreatureDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEncounterCreatureDefinition(cr2w);

	}
}