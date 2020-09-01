using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHarpyDustAttack : CBTTaskAttack
	{
		[Ordinal(0)] [RED("("addtionalFX")] 		public CName AddtionalFX { get; set;}

		[Ordinal(0)] [RED("("effectRange")] 		public CFloat EffectRange { get; set;}

		[Ordinal(0)] [RED("("effectAngle")] 		public CFloat EffectAngle { get; set;}

		[Ordinal(0)] [RED("("eventReceived")] 		public CBool EventReceived { get; set;}

		public CBTTaskHarpyDustAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskHarpyDustAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}