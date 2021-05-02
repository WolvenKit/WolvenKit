using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDoorsSettings : audioDeviceSettings
	{
		private CName _openEvent;
		private CName _openFailedEvent;
		private CName _closeEvent;
		private CName _lockEvent;
		private CName _unlockEvent;
		private CName _sealEvent;
		private CName _soundBank;

		[Ordinal(7)] 
		[RED("openEvent")] 
		public CName OpenEvent
		{
			get => GetProperty(ref _openEvent);
			set => SetProperty(ref _openEvent, value);
		}

		[Ordinal(8)] 
		[RED("openFailedEvent")] 
		public CName OpenFailedEvent
		{
			get => GetProperty(ref _openFailedEvent);
			set => SetProperty(ref _openFailedEvent, value);
		}

		[Ordinal(9)] 
		[RED("closeEvent")] 
		public CName CloseEvent
		{
			get => GetProperty(ref _closeEvent);
			set => SetProperty(ref _closeEvent, value);
		}

		[Ordinal(10)] 
		[RED("lockEvent")] 
		public CName LockEvent
		{
			get => GetProperty(ref _lockEvent);
			set => SetProperty(ref _lockEvent, value);
		}

		[Ordinal(11)] 
		[RED("unlockEvent")] 
		public CName UnlockEvent
		{
			get => GetProperty(ref _unlockEvent);
			set => SetProperty(ref _unlockEvent, value);
		}

		[Ordinal(12)] 
		[RED("sealEvent")] 
		public CName SealEvent
		{
			get => GetProperty(ref _sealEvent);
			set => SetProperty(ref _sealEvent, value);
		}

		[Ordinal(13)] 
		[RED("soundBank")] 
		public CName SoundBank
		{
			get => GetProperty(ref _soundBank);
			set => SetProperty(ref _soundBank, value);
		}

		public audioDoorsSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
