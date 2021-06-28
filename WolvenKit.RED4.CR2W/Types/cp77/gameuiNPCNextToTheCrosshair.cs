using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNPCNextToTheCrosshair : CVariable
	{
		private wCHandle<gameObject> _npc;
		private CString _name;
		private CInt32 _currentHealth;
		private CInt32 _maximumHealth;
		private CInt32 _currentCyberwarePct;
		private CInt32 _level;
		private CInt32 _quickHackUpload;
		private CEnum<EAIAttitude> _attitude;
		private CEnum<gameScanningState> _scanningState;
		private CBool _isTagged;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private CBool _canSeePlayer;
		private CBool _playerDetectionAboveZero;
		private CBool _playerDetectionAtMax;

		[Ordinal(0)] 
		[RED("npc")] 
		public wCHandle<gameObject> Npc
		{
			get => GetProperty(ref _npc);
			set => SetProperty(ref _npc, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(2)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(3)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(4)] 
		[RED("currentCyberwarePct")] 
		public CInt32 CurrentCyberwarePct
		{
			get => GetProperty(ref _currentCyberwarePct);
			set => SetProperty(ref _currentCyberwarePct, value);
		}

		[Ordinal(5)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(6)] 
		[RED("quickHackUpload")] 
		public CInt32 QuickHackUpload
		{
			get => GetProperty(ref _quickHackUpload);
			set => SetProperty(ref _quickHackUpload, value);
		}

		[Ordinal(7)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}

		[Ordinal(8)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetProperty(ref _scanningState);
			set => SetProperty(ref _scanningState, value);
		}

		[Ordinal(9)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetProperty(ref _isTagged);
			set => SetProperty(ref _isTagged, value);
		}

		[Ordinal(10)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(11)] 
		[RED("canSeePlayer")] 
		public CBool CanSeePlayer
		{
			get => GetProperty(ref _canSeePlayer);
			set => SetProperty(ref _canSeePlayer, value);
		}

		[Ordinal(12)] 
		[RED("playerDetectionAboveZero")] 
		public CBool PlayerDetectionAboveZero
		{
			get => GetProperty(ref _playerDetectionAboveZero);
			set => SetProperty(ref _playerDetectionAboveZero, value);
		}

		[Ordinal(13)] 
		[RED("playerDetectionAtMax")] 
		public CBool PlayerDetectionAtMax
		{
			get => GetProperty(ref _playerDetectionAtMax);
			set => SetProperty(ref _playerDetectionAtMax, value);
		}

		public gameuiNPCNextToTheCrosshair(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
