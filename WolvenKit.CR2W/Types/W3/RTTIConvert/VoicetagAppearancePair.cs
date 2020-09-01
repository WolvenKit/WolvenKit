using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VoicetagAppearancePair : CVariable
	{
		[Ordinal(1)] [RED("("voicetag")] 		public CName Voicetag { get; set;}

		[Ordinal(2)] [RED("("appearance")] 		public CName Appearance { get; set;}

		public VoicetagAppearancePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new VoicetagAppearancePair(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}