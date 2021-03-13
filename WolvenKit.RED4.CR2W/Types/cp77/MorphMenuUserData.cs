using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphMenuUserData : IScriptable
	{
		[Ordinal(0)] [RED("optionsListInitialized")] public CBool OptionsListInitialized { get; set; }

		public MorphMenuUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
