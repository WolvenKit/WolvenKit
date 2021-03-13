using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPingSystemMappin : gamemappinsRuntimeMappin
	{
		[Ordinal(0)] [RED("pingType")] public CEnum<gamedataPingType> PingType { get; set; }

		public gamemappinsPingSystemMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
