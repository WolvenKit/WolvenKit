using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grsHeistState : CVariable
	{
		private netTime _time;
		private CEnum<grsHeistStatus> _status;
		private CStatic<grsHeistPlayerGameInfo> _playersInfo;

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
		public CEnum<grsHeistStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<grsHeistStatus>) CR2WTypeManager.Create("grsHeistStatus", "status", cr2w, this);
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
		[RED("playersInfo", 7)] 
		public CStatic<grsHeistPlayerGameInfo> PlayersInfo
		{
			get
			{
				if (_playersInfo == null)
				{
					_playersInfo = (CStatic<grsHeistPlayerGameInfo>) CR2WTypeManager.Create("static:7,grsHeistPlayerGameInfo", "playersInfo", cr2w, this);
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

		public grsHeistState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
