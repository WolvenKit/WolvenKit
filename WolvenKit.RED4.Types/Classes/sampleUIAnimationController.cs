using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleUIAnimationController : inkWidgetLogicController
	{
		private CHandle<inkanimDefinition> _rotation_anim;
		private CHandle<inkanimDefinition> _size_anim;
		private CHandle<inkanimDefinition> _color_anim;
		private CHandle<inkanimDefinition> _alpha_anim;
		private CHandle<inkanimProxy> _rotation_anim_proxy;
		private CHandle<inkanimProxy> _size_anim_proxy;
		private CHandle<inkanimProxy> _color_anim_proxy;
		private CHandle<inkanimProxy> _alpha_anim_proxy;
		private CWeakHandle<inkWidget> _rotation_widget;
		private CWeakHandle<inkWidget> _size_widget;
		private CWeakHandle<inkWidget> _color_widget;
		private CWeakHandle<inkWidget> _alpha_widget;
		private CUInt32 _iteration_counter;
		private CBool _is_paused;
		private CBool _is_stoped;
		private CBool _playReversed;

		[Ordinal(1)] 
		[RED("rotation_anim")] 
		public CHandle<inkanimDefinition> Rotation_anim
		{
			get => GetProperty(ref _rotation_anim);
			set => SetProperty(ref _rotation_anim, value);
		}

		[Ordinal(2)] 
		[RED("size_anim")] 
		public CHandle<inkanimDefinition> Size_anim
		{
			get => GetProperty(ref _size_anim);
			set => SetProperty(ref _size_anim, value);
		}

		[Ordinal(3)] 
		[RED("color_anim")] 
		public CHandle<inkanimDefinition> Color_anim
		{
			get => GetProperty(ref _color_anim);
			set => SetProperty(ref _color_anim, value);
		}

		[Ordinal(4)] 
		[RED("alpha_anim")] 
		public CHandle<inkanimDefinition> Alpha_anim
		{
			get => GetProperty(ref _alpha_anim);
			set => SetProperty(ref _alpha_anim, value);
		}

		[Ordinal(5)] 
		[RED("rotation_anim_proxy")] 
		public CHandle<inkanimProxy> Rotation_anim_proxy
		{
			get => GetProperty(ref _rotation_anim_proxy);
			set => SetProperty(ref _rotation_anim_proxy, value);
		}

		[Ordinal(6)] 
		[RED("size_anim_proxy")] 
		public CHandle<inkanimProxy> Size_anim_proxy
		{
			get => GetProperty(ref _size_anim_proxy);
			set => SetProperty(ref _size_anim_proxy, value);
		}

		[Ordinal(7)] 
		[RED("color_anim_proxy")] 
		public CHandle<inkanimProxy> Color_anim_proxy
		{
			get => GetProperty(ref _color_anim_proxy);
			set => SetProperty(ref _color_anim_proxy, value);
		}

		[Ordinal(8)] 
		[RED("alpha_anim_proxy")] 
		public CHandle<inkanimProxy> Alpha_anim_proxy
		{
			get => GetProperty(ref _alpha_anim_proxy);
			set => SetProperty(ref _alpha_anim_proxy, value);
		}

		[Ordinal(9)] 
		[RED("rotation_widget")] 
		public CWeakHandle<inkWidget> Rotation_widget
		{
			get => GetProperty(ref _rotation_widget);
			set => SetProperty(ref _rotation_widget, value);
		}

		[Ordinal(10)] 
		[RED("size_widget")] 
		public CWeakHandle<inkWidget> Size_widget
		{
			get => GetProperty(ref _size_widget);
			set => SetProperty(ref _size_widget, value);
		}

		[Ordinal(11)] 
		[RED("color_widget")] 
		public CWeakHandle<inkWidget> Color_widget
		{
			get => GetProperty(ref _color_widget);
			set => SetProperty(ref _color_widget, value);
		}

		[Ordinal(12)] 
		[RED("alpha_widget")] 
		public CWeakHandle<inkWidget> Alpha_widget
		{
			get => GetProperty(ref _alpha_widget);
			set => SetProperty(ref _alpha_widget, value);
		}

		[Ordinal(13)] 
		[RED("iteration_counter")] 
		public CUInt32 Iteration_counter
		{
			get => GetProperty(ref _iteration_counter);
			set => SetProperty(ref _iteration_counter, value);
		}

		[Ordinal(14)] 
		[RED("is_paused")] 
		public CBool Is_paused
		{
			get => GetProperty(ref _is_paused);
			set => SetProperty(ref _is_paused, value);
		}

		[Ordinal(15)] 
		[RED("is_stoped")] 
		public CBool Is_stoped
		{
			get => GetProperty(ref _is_stoped);
			set => SetProperty(ref _is_stoped, value);
		}

		[Ordinal(16)] 
		[RED("playReversed")] 
		public CBool PlayReversed
		{
			get => GetProperty(ref _playReversed);
			set => SetProperty(ref _playReversed, value);
		}
	}
}
