using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEntityTemplateOverride : CVariable
	{
		[Ordinal(0)] [RED("("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(0)] [RED("("className")] 		public CName ClassName { get; set;}

		[Ordinal(0)] [RED("("overriddenProperties", 2,0)] 		public CArray<CName> OverriddenProperties { get; set;}

		public SEntityTemplateOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEntityTemplateOverride(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}