using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class SAppearanceAttachment : CVariable
	{
		[Ordinal(0)] [RED("parentClass")] 		public CName ParentClass { get; set;}

		[Ordinal(0)] [RED("parentName")] 		public CName ParentName { get; set;}

		[Ordinal(0)] [RED("childClass")] 		public CName ChildClass { get; set;}

		[Ordinal(0)] [RED("childName")] 		public CName ChildName { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAppearanceAttachment(cr2w, parent, name);

	}
}