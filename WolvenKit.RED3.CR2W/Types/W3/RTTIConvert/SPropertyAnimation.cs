using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPropertyAnimation : CVariable
	{
		[Ordinal(1)] [RED("propertyName")] 		public CName PropertyName { get; set;}

		[Ordinal(2)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(3)] [RED("curve")] 		public SMultiCurve Curve { get; set;}

		[Ordinal(4)] [RED("playOnStartup")] 		public CBool PlayOnStartup { get; set;}

		[Ordinal(5)] [RED("effectToPlay")] 		public CName EffectToPlay { get; set;}

		public SPropertyAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPropertyAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}