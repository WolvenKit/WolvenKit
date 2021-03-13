using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimAnimationLibraryResource : CResource
	{
		[Ordinal(1)] [RED("sequences")] public CArray<CHandle<inkanimSequence>> Sequences { get; set; }

		public inkanimAnimationLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
