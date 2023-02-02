using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTransformAnimatorNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("action")] 
		public CHandle<questTransformAnimatorNode_ActionType> Action
		{
			get => GetPropertyValue<CHandle<questTransformAnimatorNode_ActionType>>();
			set => SetPropertyValue<CHandle<questTransformAnimatorNode_ActionType>>(value);
		}

		public questTransformAnimatorNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			ObjectRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
