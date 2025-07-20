using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AutodriveQuestContentLockListener : questScriptQuestContentLockListener
	{
		[Ordinal(0)] 
		[RED("autodriveSystem")] 
		public CWeakHandle<AutoDriveSystem> AutodriveSystem
		{
			get => GetPropertyValue<CWeakHandle<AutoDriveSystem>>();
			set => SetPropertyValue<CWeakHandle<AutoDriveSystem>>(value);
		}

		public AutodriveQuestContentLockListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
