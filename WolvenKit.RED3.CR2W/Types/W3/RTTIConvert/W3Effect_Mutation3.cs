using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Mutation3 : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("stacks")] 		public CInt32 Stacks { get; set;}

		[Ordinal(2)] [RED("maxCap")] 		public CInt32 MaxCap { get; set;}

		[Ordinal(3)] [RED("apBonus")] 		public CFloat ApBonus { get; set;}

		public W3Effect_Mutation3(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Mutation3(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}