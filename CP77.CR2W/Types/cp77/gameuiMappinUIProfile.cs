using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinUIProfile : CVariable
	{
		[Ordinal(0)]  [RED("runtime")] public CHandle<gamedataMappinUIRuntimeProfile_Record> Runtime { get; set; }
		[Ordinal(1)]  [RED("spawn")] public CHandle<gamedataMappinUISpawnProfile_Record> Spawn { get; set; }
		[Ordinal(2)]  [RED("widgetLibraryID")] public CName WidgetLibraryID { get; set; }
		[Ordinal(3)]  [RED("widgetResource")] public redResourceReferenceScriptToken WidgetResource { get; set; }

		public gameuiMappinUIProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
