using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EyeOfLoki : W3QuestUsableItem
	{
		[Ordinal(1)] [RED("environment")] 		public CName Environment { get; set;}

		[Ordinal(2)] [RED("effect")] 		public CName Effect { get; set;}

		[Ordinal(3)] [RED("activeWhenFact")] 		public CName ActiveWhenFact { get; set;}

		[Ordinal(4)] [RED("soundOnStart")] 		public CName SoundOnStart { get; set;}

		[Ordinal(5)] [RED("soundOnStop")] 		public CName SoundOnStop { get; set;}

		[Ordinal(6)] [RED("envID")] 		public CInt32 EnvID { get; set;}

		[Ordinal(7)] [RED("active")] 		public CBool Active { get; set;}

		public W3EyeOfLoki(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}