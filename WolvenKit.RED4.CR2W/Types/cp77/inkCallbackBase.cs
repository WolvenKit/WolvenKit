using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCallbackBase : CVariable
	{
		[Ordinal(0)] [RED("callbackName")] public CName CallbackName { get; set; }
		[Ordinal(1)] [RED("listeners")] public CArray<inkCallbackListener> Listeners { get; set; }

		public inkCallbackBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
