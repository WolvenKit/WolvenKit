using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MusicBandActivatorArea : CEntity
	{
		[RED("musiciansTag")] 		public CName MusiciansTag { get; set;}

		[RED("interiorSoundEmitter")] 		public CHandle<CEntityTemplate> InteriorSoundEmitter { get; set;}

		[RED("exteriorSoundEmitter")] 		public CHandle<CEntityTemplate> ExteriorSoundEmitter { get; set;}

		[RED("exterior")] 		public CBool Exterior { get; set;}

		[RED("minimalNumberOfMusicions")] 		public CInt32 MinimalNumberOfMusicions { get; set;}

		public W3MusicBandActivatorArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MusicBandActivatorArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}