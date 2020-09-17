using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHarpyDustAttackDef : CBTTaskAttackDef
	{
		[Ordinal(1)] [RED("addtionalFX")] 		public CName AddtionalFX { get; set;}

		[Ordinal(2)] [RED("effectRange")] 		public CFloat EffectRange { get; set;}

		[Ordinal(3)] [RED("effectAngle")] 		public CFloat EffectAngle { get; set;}

		public CBTTaskHarpyDustAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskHarpyDustAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}