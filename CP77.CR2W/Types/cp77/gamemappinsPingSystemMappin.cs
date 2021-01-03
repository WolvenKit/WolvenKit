using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPingSystemMappin : gamemappinsRuntimeMappin
	{
		[Ordinal(0)]  [RED("pingType")] public CEnum<gamedataPingType> PingType { get; set; }

		public gamemappinsPingSystemMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
