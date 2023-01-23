using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConstantStatPoolPrereqState : StatPoolPrereqState
	{
		[Ordinal(5)] 
		[RED("listenConstantly")] 
		public CBool ListenConstantly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ConstantStatPoolPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
