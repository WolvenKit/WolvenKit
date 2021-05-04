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
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<grsHeistStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(2)] 
		[RED("playersInfo", 7)] 
		public CStatic<grsHeistPlayerGameInfo> PlayersInfo
		{
			get => GetProperty(ref _playersInfo);
			set => SetProperty(ref _playersInfo, value);
		}

		public grsHeistState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
