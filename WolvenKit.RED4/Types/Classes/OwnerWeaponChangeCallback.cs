using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OwnerWeaponChangeCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("followerRole")] 
		public CHandle<AIFollowerRole> FollowerRole
		{
			get => GetPropertyValue<CHandle<AIFollowerRole>>();
			set => SetPropertyValue<CHandle<AIFollowerRole>>(value);
		}

		public OwnerWeaponChangeCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
