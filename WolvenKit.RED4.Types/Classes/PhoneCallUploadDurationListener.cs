using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhoneCallUploadDurationListener : gameCustomValueStatPoolsListener
	{
		private ScriptGameInstance _gameInstance;
		private CWeakHandle<ScriptedPuppet> _requesterPuppet;
		private entEntityID _requesterID;
		private CFloat _duration;
		private CEnum<gamedataStatPoolType> _statPoolType;

		[Ordinal(0)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(1)] 
		[RED("requesterPuppet")] 
		public CWeakHandle<ScriptedPuppet> RequesterPuppet
		{
			get => GetProperty(ref _requesterPuppet);
			set => SetProperty(ref _requesterPuppet, value);
		}

		[Ordinal(2)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}
	}
}
