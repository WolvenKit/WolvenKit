using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCameraAnimationData : CVariable
	{
		[Ordinal(1)] [RED("animation")] 		public CName Animation { get; set;}

		[Ordinal(2)] [RED("priority")] 		public CEnum<ECameraAnimPriority> Priority { get; set;}

		[Ordinal(3)] [RED("blend")] 		public CFloat Blend { get; set;}

		[Ordinal(4)] [RED("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(5)] [RED("loop")] 		public CBool Loop { get; set;}

		public SCameraAnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCameraAnimationData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}