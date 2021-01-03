using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DisableBraindanceActions : redEvent
	{
		[Ordinal(0)]  [RED("actionMask")] public SBraindanceInputMask ActionMask { get; set; }

		public DisableBraindanceActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
