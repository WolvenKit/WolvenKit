using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimatedSlideSettings : CVariable
	{
		[RED("animation")] 		public CName Animation { get; set;}

		[RED("slotName")] 		public CName SlotName { get; set;}

		[RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[RED("useGameTimeScale")] 		public CBool UseGameTimeScale { get; set;}

		[RED("useRotationDeltaPolicy")] 		public CBool UseRotationDeltaPolicy { get; set;}

		public SAnimatedSlideSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimatedSlideSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}