using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioNpcWeaponSettings : audioWeaponSettings
	{
		private CName _gunChoir;
		private CName _tails;
		private CBool _obstructionEnabled;
		private CBool _occlusionEnabled;
		private CBool _repositionEnabled;
		private CFloat _obstructionChangeTime;
		private CBool _disablePathfinding;
		private CFloat _voiceSwitchCooldown;
		private CName _reloadSound;
		private CName _quickMeleeAttackSound;
		private CName _quickMeleeHitSound;

		[Ordinal(10)] 
		[RED("gunChoir")] 
		public CName GunChoir
		{
			get => GetProperty(ref _gunChoir);
			set => SetProperty(ref _gunChoir, value);
		}

		[Ordinal(11)] 
		[RED("tails")] 
		public CName Tails
		{
			get => GetProperty(ref _tails);
			set => SetProperty(ref _tails, value);
		}

		[Ordinal(12)] 
		[RED("obstructionEnabled")] 
		public CBool ObstructionEnabled
		{
			get => GetProperty(ref _obstructionEnabled);
			set => SetProperty(ref _obstructionEnabled, value);
		}

		[Ordinal(13)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetProperty(ref _occlusionEnabled);
			set => SetProperty(ref _occlusionEnabled, value);
		}

		[Ordinal(14)] 
		[RED("repositionEnabled")] 
		public CBool RepositionEnabled
		{
			get => GetProperty(ref _repositionEnabled);
			set => SetProperty(ref _repositionEnabled, value);
		}

		[Ordinal(15)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetProperty(ref _obstructionChangeTime);
			set => SetProperty(ref _obstructionChangeTime, value);
		}

		[Ordinal(16)] 
		[RED("disablePathfinding")] 
		public CBool DisablePathfinding
		{
			get => GetProperty(ref _disablePathfinding);
			set => SetProperty(ref _disablePathfinding, value);
		}

		[Ordinal(17)] 
		[RED("voiceSwitchCooldown")] 
		public CFloat VoiceSwitchCooldown
		{
			get => GetProperty(ref _voiceSwitchCooldown);
			set => SetProperty(ref _voiceSwitchCooldown, value);
		}

		[Ordinal(18)] 
		[RED("reloadSound")] 
		public CName ReloadSound
		{
			get => GetProperty(ref _reloadSound);
			set => SetProperty(ref _reloadSound, value);
		}

		[Ordinal(19)] 
		[RED("quickMeleeAttackSound")] 
		public CName QuickMeleeAttackSound
		{
			get => GetProperty(ref _quickMeleeAttackSound);
			set => SetProperty(ref _quickMeleeAttackSound, value);
		}

		[Ordinal(20)] 
		[RED("quickMeleeHitSound")] 
		public CName QuickMeleeHitSound
		{
			get => GetProperty(ref _quickMeleeHitSound);
			set => SetProperty(ref _quickMeleeHitSound, value);
		}

		public audioNpcWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
