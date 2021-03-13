using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEntityTemplateOverride : CVariable
	{
		[Ordinal(1)] [RED("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(2)] [RED("className")] 		public CName ClassName { get; set;}

		[Ordinal(3)] [RED("overriddenProperties", 2,0)] 		public CArray<CName> OverriddenProperties { get; set;}

		public SEntityTemplateOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEntityTemplateOverride(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}