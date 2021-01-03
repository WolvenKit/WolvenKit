using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CooldownStorage : IScriptable
	{
		[Ordinal(0)]  [RED("currentID")] public CUInt32 CurrentID { get; set; }
		[Ordinal(1)]  [RED("gameInstanceHack")] public ScriptGameInstance GameInstanceHack { get; set; }
		[Ordinal(2)]  [RED("initialized")] public CEnum<EBOOL> Initialized { get; set; }
		[Ordinal(3)]  [RED("map")] public CArray<CooldownPackageDelayIDs> Map { get; set; }
		[Ordinal(4)]  [RED("owner")] public PSOwnerData Owner { get; set; }
		[Ordinal(5)]  [RED("packages")] public CArray<CHandle<CooldownPackage>> Packages { get; set; }

		public CooldownStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
