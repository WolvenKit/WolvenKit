using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFalling : IBehTreeTask
	{
		[Ordinal(1)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		[Ordinal(2)] [RED("drawableComp")] 		public CHandle<CDrawableComponent> DrawableComp { get; set;}

		[Ordinal(3)] [RED("fakeBroomHidden")] 		public CBool FakeBroomHidden { get; set;}

		[Ordinal(4)] [RED("attachedToGround")] 		public CBool AttachedToGround { get; set;}

		[Ordinal(5)] [RED("broomSpawned")] 		public CBool BroomSpawned { get; set;}

		public CBTTaskFalling(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}