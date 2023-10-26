using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIQuickHackAction : PuppetAction
	{
		[Ordinal(39)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(40)] 
		[RED("scaleUploadTime")] 
		public CBool ScaleUploadTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIQuickHackAction()
		{
			ScaleUploadTime = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
