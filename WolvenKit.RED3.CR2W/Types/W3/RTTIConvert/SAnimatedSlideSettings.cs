using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimatedSlideSettings : CVariable
	{
		[Ordinal(1)] [RED("animation")] 		public CName Animation { get; set;}

		[Ordinal(2)] [RED("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(3)] [RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[Ordinal(4)] [RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[Ordinal(5)] [RED("useGameTimeScale")] 		public CBool UseGameTimeScale { get; set;}

		[Ordinal(6)] [RED("useRotationDeltaPolicy")] 		public CBool UseRotationDeltaPolicy { get; set;}

		public SAnimatedSlideSettings(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimatedSlideSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}