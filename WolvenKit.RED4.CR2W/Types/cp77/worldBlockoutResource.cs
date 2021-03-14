using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutResource : CResource
	{
		[Ordinal(1)] [RED("blockoutData")] public CHandle<worldBlockoutData> BlockoutData { get; set; }

		public worldBlockoutResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
