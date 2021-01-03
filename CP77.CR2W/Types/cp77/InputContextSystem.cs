using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InputContextSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("activeContext")] public CEnum<inputContextType> ActiveContext { get; set; }

		public InputContextSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
