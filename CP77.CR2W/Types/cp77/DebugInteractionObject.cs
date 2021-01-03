using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DebugInteractionObject : gameObject
	{
		[Ordinal(0)]  [RED("choices")] public CArray<SDebugChoice> Choices { get; set; }
		[Ordinal(1)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }

		public DebugInteractionObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
