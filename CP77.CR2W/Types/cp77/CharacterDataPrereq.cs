using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CharacterDataPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("idToCheck")] public TweakDBID IdToCheck { get; set; }

		public CharacterDataPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
