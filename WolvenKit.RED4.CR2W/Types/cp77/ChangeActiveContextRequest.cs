using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeActiveContextRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("newContext")] public CEnum<inputContextType> NewContext { get; set; }

		public ChangeActiveContextRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
