using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Aura : W3ApplicatorEffect
	{
		[Ordinal(0)] [RED("("isOneTimeOnly")] 		public CBool IsOneTimeOnly { get; set;}

		[Ordinal(0)] [RED("("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("("flags")] 		public CInt32 Flags { get; set;}

		public W3Effect_Aura(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Aura(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}