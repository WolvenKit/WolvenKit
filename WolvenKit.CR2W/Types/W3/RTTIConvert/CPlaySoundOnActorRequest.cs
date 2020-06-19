using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPlaySoundOnActorRequest : IEntityStateChangeRequest
	{
		[RED("boneName")] 		public CName BoneName { get; set;}

		[RED("soundName")] 		public StringAnsi SoundName { get; set;}

		[RED("fadeTime")] 		public CFloat FadeTime { get; set;}

		public CPlaySoundOnActorRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPlaySoundOnActorRequest(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}