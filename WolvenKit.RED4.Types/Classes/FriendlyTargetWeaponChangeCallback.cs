using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FriendlyTargetWeaponChangeCallback : gameAttachmentSlotsScriptCallback
	{
		private CHandle<AIFollowerRole> _followerRole;

		[Ordinal(2)] 
		[RED("followerRole")] 
		public CHandle<AIFollowerRole> FollowerRole
		{
			get => GetProperty(ref _followerRole);
			set => SetProperty(ref _followerRole, value);
		}
	}
}
