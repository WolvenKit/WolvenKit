using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventSound : CStorySceneEvent
	{
		[Ordinal(1)] [RED("soundEventName")] 		public StringAnsi SoundEventName { get; set;}

		[Ordinal(2)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(3)] [RED("bone")] 		public CName Bone { get; set;}

		[Ordinal(4)] [RED("dbVolume")] 		public CFloat DbVolume { get; set;}

		public CStorySceneEventSound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventSound(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}