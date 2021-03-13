using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEntityTemplateColoringEntry : CVariable
	{
		[Ordinal(1)] [RED("appearance")] 		public CName Appearance { get; set;}

		[Ordinal(2)] [RED("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(3)] [RED("colorShift1")] 		public CColorShift ColorShift1 { get; set;}

		[Ordinal(4)] [RED("colorShift2")] 		public CColorShift ColorShift2 { get; set;}

		public SEntityTemplateColoringEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEntityTemplateColoringEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}