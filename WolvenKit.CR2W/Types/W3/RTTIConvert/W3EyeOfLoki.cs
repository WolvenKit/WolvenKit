using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EyeOfLoki : W3QuestUsableItem
	{
		[Ordinal(0)] [RED("("environment")] 		public CName Environment { get; set;}

		[Ordinal(0)] [RED("("effect")] 		public CName Effect { get; set;}

		[Ordinal(0)] [RED("("activeWhenFact")] 		public CName ActiveWhenFact { get; set;}

		[Ordinal(0)] [RED("("soundOnStart")] 		public CName SoundOnStart { get; set;}

		[Ordinal(0)] [RED("("soundOnStop")] 		public CName SoundOnStop { get; set;}

		[Ordinal(0)] [RED("("envID")] 		public CInt32 EnvID { get; set;}

		[Ordinal(0)] [RED("("active")] 		public CBool Active { get; set;}

		public W3EyeOfLoki(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3EyeOfLoki(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}