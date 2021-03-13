using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entComponentsStorage : ISerializable
	{
		[Ordinal(0)] [RED("components")] public CArray<CHandle<entIComponent>> Components { get; set; }

		public entComponentsStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
