using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DismembermentTriggeredPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("listenerInfo")] 
		public CHandle<redCallbackObject> ListenerInfo
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("dismembermentInfo")] 
		public DismembermentInstigatedInfo DismembermentInfo
		{
			get => GetPropertyValue<DismembermentInstigatedInfo>();
			set => SetPropertyValue<DismembermentInstigatedInfo>(value);
		}

		public DismembermentTriggeredPrereqState()
		{
			DismembermentInfo = new DismembermentInstigatedInfo { TargetPosition = new Vector4(), AttackPosition = new Vector4() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
