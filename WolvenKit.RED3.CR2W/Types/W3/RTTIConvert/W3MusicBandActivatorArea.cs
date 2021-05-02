using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MusicBandActivatorArea : CEntity
	{
		[Ordinal(1)] [RED("musiciansTag")] 		public CName MusiciansTag { get; set;}

		[Ordinal(2)] [RED("interiorSoundEmitter")] 		public CHandle<CEntityTemplate> InteriorSoundEmitter { get; set;}

		[Ordinal(3)] [RED("exteriorSoundEmitter")] 		public CHandle<CEntityTemplate> ExteriorSoundEmitter { get; set;}

		[Ordinal(4)] [RED("exterior")] 		public CBool Exterior { get; set;}

		[Ordinal(5)] [RED("minimalNumberOfMusicions")] 		public CInt32 MinimalNumberOfMusicions { get; set;}

		[Ordinal(6)] [RED("activeSoundEmitter")] 		public CHandle<CEntity> ActiveSoundEmitter { get; set;}

		[Ordinal(7)] [RED("activeMusician")] 		public CHandle<CEntity> ActiveMusician { get; set;}

		[Ordinal(8)] [RED("activeMusicians", 2,0)] 		public CArray<CHandle<CEntity>> ActiveMusicians { get; set;}

		[Ordinal(9)] [RED("activeArea")] 		public CHandle<CTriggerAreaComponent> ActiveArea { get; set;}

		[Ordinal(10)] [RED("jobTreeType")] 		public CEnum<EJobTreeType> JobTreeType { get; set;}

		public W3MusicBandActivatorArea(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MusicBandActivatorArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}