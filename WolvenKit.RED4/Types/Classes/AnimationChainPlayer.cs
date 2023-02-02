using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimationChainPlayer : IScriptable
	{
		[Ordinal(0)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(1)] 
		[RED("current")] 
		public CHandle<AnimationChain> Current
		{
			get => GetPropertyValue<CHandle<AnimationChain>>();
			set => SetPropertyValue<CHandle<AnimationChain>>(value);
		}

		[Ordinal(2)] 
		[RED("current_stage")] 
		public CInt32 Current_stage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("next")] 
		public CHandle<AnimationChain> Next
		{
			get => GetPropertyValue<CHandle<AnimationChain>>();
			set => SetPropertyValue<CHandle<AnimationChain>>(value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public CWeakHandle<inkWidgetLogicController> Owner
		{
			get => GetPropertyValue<CWeakHandle<inkWidgetLogicController>>();
			set => SetPropertyValue<CWeakHandle<inkWidgetLogicController>>(value);
		}

		public AnimationChainPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
