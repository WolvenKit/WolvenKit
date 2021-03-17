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
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<grsDeathmatchStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(2)] 
		[RED("sessionLength")] 
		public netTime SessionLength
		{
			get => GetProperty(ref _sessionLength);
			set => SetProperty(ref _sessionLength, value);
		}

		[Ordinal(3)] 
		[RED("playersInfo", 7)] 
		public CStatic<grsDeathmatchPlayerGameInfo> PlayersInfo
		{
			get => GetProperty(ref _playersInfo);
			set => SetProperty(ref _playersInfo, value);
		}

		public grsDeathmatchState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
