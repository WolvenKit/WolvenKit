using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TvChannelSpawnData : IScriptable
	{
		private CName _channelName;
		private CString _localizedName;

		[Ordinal(0)] 
		[RED("channelName")] 
		public CName ChannelName
		{
			get => GetProperty(ref _channelName);
			set => SetProperty(ref _channelName, value);
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		public TvChannelSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
