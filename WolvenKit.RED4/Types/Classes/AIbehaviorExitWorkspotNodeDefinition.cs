using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorExitWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("skipExitAnimation")] 
		public CHandle<AIArgumentMapping> SkipExitAnimation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("useSlowExitAnimation")] 
		public CHandle<AIArgumentMapping> UseSlowExitAnimation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("doSlowIfFastExitFails")] 
		public CHandle<AIArgumentMapping> DoSlowIfFastExitFails
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("stayInWorkspotIfExitFails")] 
		public CHandle<AIArgumentMapping> StayInWorkspotIfExitFails
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("tryBlendFastExitToWalk")] 
		public CHandle<AIArgumentMapping> TryBlendFastExitToWalk
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("dontRequestExit")] 
		public CHandle<AIArgumentMapping> DontRequestExit
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorExitWorkspotNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
