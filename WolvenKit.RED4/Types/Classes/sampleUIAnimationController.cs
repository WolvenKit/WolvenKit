using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUIAnimationController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("rotation_anim")] 
		public CHandle<inkanimDefinition> Rotation_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(2)] 
		[RED("size_anim")] 
		public CHandle<inkanimDefinition> Size_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(3)] 
		[RED("color_anim")] 
		public CHandle<inkanimDefinition> Color_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("alpha_anim")] 
		public CHandle<inkanimDefinition> Alpha_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(5)] 
		[RED("rotation_anim_proxy")] 
		public CHandle<inkanimProxy> Rotation_anim_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("size_anim_proxy")] 
		public CHandle<inkanimProxy> Size_anim_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(7)] 
		[RED("color_anim_proxy")] 
		public CHandle<inkanimProxy> Color_anim_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(8)] 
		[RED("alpha_anim_proxy")] 
		public CHandle<inkanimProxy> Alpha_anim_proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(9)] 
		[RED("rotation_widget")] 
		public CWeakHandle<inkWidget> Rotation_widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("size_widget")] 
		public CWeakHandle<inkWidget> Size_widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("color_widget")] 
		public CWeakHandle<inkWidget> Color_widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("alpha_widget")] 
		public CWeakHandle<inkWidget> Alpha_widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("iteration_counter")] 
		public CUInt32 Iteration_counter
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(14)] 
		[RED("is_paused")] 
		public CBool Is_paused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("is_stoped")] 
		public CBool Is_stoped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("playReversed")] 
		public CBool PlayReversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public sampleUIAnimationController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
