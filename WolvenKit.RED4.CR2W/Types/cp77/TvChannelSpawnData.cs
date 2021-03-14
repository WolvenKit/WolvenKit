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
			get
			{
				if (_channelName == null)
				{
					_channelName = (CName) CR2WTypeManager.Create("CName", "channelName", cr2w, this);
				}
				return _channelName;
			}
			set
			{
				if (_channelName == value)
				{
					return;
				}
				_channelName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CString) CR2WTypeManager.Create("String", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		public TvChannelSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
