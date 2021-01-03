using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workDynamicSyncBindCommandData : workIWorkspotCommandData
	{
		[Ordinal(0)]  [RED("masterID")] public entEntityID MasterID { get; set; }

		public workDynamicSyncBindCommandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
