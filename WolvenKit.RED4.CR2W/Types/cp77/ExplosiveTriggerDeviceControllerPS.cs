using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveTriggerDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		private CBool _playerSafePass;
		private CBool _triggerExploded;

		[Ordinal(120)] 
		[RED("playerSafePass")] 
		public CBool PlayerSafePass
		{
			get => GetProperty(ref _playerSafePass);
			set => SetProperty(ref _playerSafePass, value);
		}

		[Ordinal(121)] 
		[RED("triggerExploded")] 
		public CBool TriggerExploded
		{
			get => GetProperty(ref _triggerExploded);
			set => SetProperty(ref _triggerExploded, value);
		}

		public ExplosiveTriggerDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
