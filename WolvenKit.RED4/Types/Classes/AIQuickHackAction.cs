using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIQuickHackAction : PuppetAction
	{
		[Ordinal(38)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(39)] 
		[RED("scaleUploadTime")] 
		public CBool ScaleUploadTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIQuickHackAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
