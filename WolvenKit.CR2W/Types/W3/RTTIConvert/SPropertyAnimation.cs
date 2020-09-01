using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPropertyAnimation : CVariable
	{
		[Ordinal(0)] [RED("("propertyName")] 		public CName PropertyName { get; set;}

		[Ordinal(0)] [RED("("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(0)] [RED("("curve")] 		public SMultiCurve Curve { get; set;}

		[Ordinal(0)] [RED("("playOnStartup")] 		public CBool PlayOnStartup { get; set;}

		[Ordinal(0)] [RED("("effectToPlay")] 		public CName EffectToPlay { get; set;}

		public SPropertyAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPropertyAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}