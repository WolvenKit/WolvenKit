using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerSendAnimationEvent_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questEntityManagerSendAnimationEvent_NodeType()
		{
			ObjectRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
