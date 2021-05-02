using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class SAppearanceAttachment : CVariable
	{
		[Ordinal(1)] [RED("parentClass")] 		public CName ParentClass { get; set;}

		[Ordinal(2)] [RED("parentName")] 		public CName ParentName { get; set;}

		[Ordinal(3)] [RED("childClass")] 		public CName ChildClass { get; set;}

		[Ordinal(4)] [RED("childName")] 		public CName ChildName { get; set;}

	}
}
