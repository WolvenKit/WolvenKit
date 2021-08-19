using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccessPointControllerPS : MasterControllerPS
	{
		private CArray<CString> _rewardNotificationIcons;
		private CString _rewardNotificationString;
		private CHandle<HackingContainer> _accessPointSkillChecks;
		private CBool _isBreached;
		private CBool _isVirtual;
		private CArray<CName> _pingedSquads;

		[Ordinal(105)] 
		[RED("rewardNotificationIcons")] 
		public CArray<CString> RewardNotificationIcons
		{
			get => GetProperty(ref _rewardNotificationIcons);
			set => SetProperty(ref _rewardNotificationIcons, value);
		}

		[Ordinal(106)] 
		[RED("rewardNotificationString")] 
		public CString RewardNotificationString
		{
			get => GetProperty(ref _rewardNotificationString);
			set => SetProperty(ref _rewardNotificationString, value);
		}

		[Ordinal(107)] 
		[RED("accessPointSkillChecks")] 
		public CHandle<HackingContainer> AccessPointSkillChecks
		{
			get => GetProperty(ref _accessPointSkillChecks);
			set => SetProperty(ref _accessPointSkillChecks, value);
		}

		[Ordinal(108)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get => GetProperty(ref _isBreached);
			set => SetProperty(ref _isBreached, value);
		}

		[Ordinal(109)] 
		[RED("isVirtual")] 
		public CBool IsVirtual
		{
			get => GetProperty(ref _isVirtual);
			set => SetProperty(ref _isVirtual, value);
		}

		[Ordinal(110)] 
		[RED("pingedSquads")] 
		public CArray<CName> PingedSquads
		{
			get => GetProperty(ref _pingedSquads);
			set => SetProperty(ref _pingedSquads, value);
		}

		public AccessPointControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
