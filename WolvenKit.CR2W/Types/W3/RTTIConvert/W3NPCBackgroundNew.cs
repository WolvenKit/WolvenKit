using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3NPCBackgroundNew : CEntity
	{
		[RED("behaviorWorkNumber")] 		public CInt32 BehaviorWorkNumber { get; set;}

		[RED("randomized")] 		public CBool Randomized { get; set;}

		[RED("maxWorkNumber")] 		public CInt32 MaxWorkNumber { get; set;}

		[RED("excludeIdle")] 		public CBool ExcludeIdle { get; set;}

		public W3NPCBackgroundNew(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3NPCBackgroundNew(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}