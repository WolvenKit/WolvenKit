using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCameraAnimationData : CVariable
	{
		[RED("animation")] 		public CName Animation { get; set;}

		[RED("priority")] 		public CEnum<ECameraAnimPriority> Priority { get; set;}

		[RED("blend")] 		public CFloat Blend { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("loop")] 		public CBool Loop { get; set;}

		public SCameraAnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCameraAnimationData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}