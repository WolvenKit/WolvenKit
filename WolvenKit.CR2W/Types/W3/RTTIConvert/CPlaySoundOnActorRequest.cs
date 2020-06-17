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

		public CPlaySoundOnActorRequest(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CPlaySoundOnActorRequest(cr2w);

	}
}