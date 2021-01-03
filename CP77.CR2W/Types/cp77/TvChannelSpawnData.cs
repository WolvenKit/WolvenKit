using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TvChannelSpawnData : IScriptable
	{
		[Ordinal(0)]  [RED("channelName")] public CName ChannelName { get; set; }
		[Ordinal(1)]  [RED("localizedName")] public CString LocalizedName { get; set; }

		public TvChannelSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
