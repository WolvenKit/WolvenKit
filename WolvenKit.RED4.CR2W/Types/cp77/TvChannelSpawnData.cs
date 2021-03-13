using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TvChannelSpawnData : IScriptable
	{
		[Ordinal(0)] [RED("channelName")] public CName ChannelName { get; set; }
		[Ordinal(1)] [RED("localizedName")] public CString LocalizedName { get; set; }

		public TvChannelSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
