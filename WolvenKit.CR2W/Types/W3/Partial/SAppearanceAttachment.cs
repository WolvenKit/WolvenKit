using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class SAppearanceAttachment : CVariable
	{
		[RED("parentClass")] 		public CName ParentClass { get; set;}

		[RED("parentName")] 		public CName ParentName { get; set;}

		[RED("childClass")] 		public CName ChildClass { get; set;}

		[RED("childName")] 		public CName ChildName { get; set;}

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAppearanceAttachment(cr2w, parent, name);

	}
}