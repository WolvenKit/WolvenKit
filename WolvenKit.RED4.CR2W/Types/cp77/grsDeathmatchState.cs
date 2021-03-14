using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grsDeathmatchState : CVariable
	{
		private netTime _time;
		private CEnum<grsDeathmatchStatus> _status;
		private netTime _sessionLength;
		private CStatic<grsDeathmatchPlayerGameInfo> _playersInfo;

		[Ordinal(0)] 
		[RED("time")] 
		public netTime Time
		{
			get
			{
				if (_time == null)
				{
					_time = (netTime) CR2WTypeManager.Create("netTime", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<grsDeathmatchStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<grsDeathmatchStatus>) CR2WTypeManager.Create("grsDeathmatchStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sessionLength")] 
		public netTime SessionLength
		{
			get
			{
				if (_sessionLength == null)
				{
					_sessionLength = (netTime) CR2WTypeManager.Create("netTime", "sessionLength", cr2w, this);
				}
				return _sessionLength;
			}
			set
			{
				if (_sessionLength == value)
				{
					return;
				}
				_sessionLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playersInfo", 7)] 
		public CStatic<grsDeathmatchPlayerGameInfo> PlayersInfo
		{
			get
			{
				if (_playersInfo == null)
				{
					_playersInfo = (CStatic<grsDeathmatchPlayerGameInfo>) CR2WTypeManager.Create("static:7,grsDeathmatchPlayerGameInfo", "playersInfo", cr2w, this);
				}
				return _playersInfo;
			}
			set
			{
				if (_playersInfo == value)
				{
					return;
				}
				_playersInfo = value;
				PropertySet(this);
			}
		}

		public grsDeathmatchState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
