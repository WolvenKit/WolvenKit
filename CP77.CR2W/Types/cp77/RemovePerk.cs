using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RemovePerk : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("perkType")] public CEnum<gamedataPerkType> PerkType { get; set; }

		public RemovePerk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
