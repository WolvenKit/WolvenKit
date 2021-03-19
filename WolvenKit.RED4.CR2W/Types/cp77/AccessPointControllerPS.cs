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

		[Ordinal(104)] 
		[RED("rewardNotificationIcons")] 
		public CArray<CString> RewardNotificationIcons
		{
			get => GetProperty(ref _rewardNotificationIcons);
			set => SetProperty(ref _rewardNotificationIcons, value);
		}

		[Ordinal(105)] 
		[RED("rewardNotificationString")] 
		public CString RewardNotificationString
		{
			get => GetProperty(ref _rewardNotificationString);
			set => SetProperty(ref _rewardNotificationString, value);
		}

		[Ordinal(106)] 
		[RED("accessPointSkillChecks")] 
		public CHandle<HackingContainer> AccessPointSkillChecks
		{
			get => GetProperty(ref _accessPointSkillChecks);
			set => SetProperty(ref _accessPointSkillChecks, value);
		}

		[Ordinal(107)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get => GetProperty(ref _isBreached);
			set => SetProperty(ref _isBreached, value);
		}

		[Ordinal(108)] 
		[RED("isVirtual")] 
		public CBool IsVirtual
		{
			get => GetProperty(ref _isVirtual);
			set => SetProperty(ref _isVirtual, value);
		}

		public AccessPointControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
