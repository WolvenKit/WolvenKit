using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCameraAnimationDefinition : CVariable
	{
		[RED("animation")] 		public CName Animation { get; set;}

		[RED("priority")] 		public CInt32 Priority { get; set;}

		[RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[RED("blendOut")] 		public CFloat BlendOut { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("loop")] 		public CBool Loop { get; set;}

		[RED("reset")] 		public CBool Reset { get; set;}

		[RED("additive")] 		public CBool Additive { get; set;}

		[RED("exclusive")] 		public CBool Exclusive { get; set;}

		public SCameraAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCameraAnimationDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}