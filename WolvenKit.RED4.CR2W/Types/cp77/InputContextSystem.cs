using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputContextSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("activeContext")] public CEnum<inputContextType> ActiveContext { get; set; }

		public InputContextSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
