using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkPropertyManager : ISerializable
	{
		[Ordinal(0)]  [RED("bindings")] public CArray<inkPropertyBinding> Bindings { get; set; }

		public inkPropertyManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
