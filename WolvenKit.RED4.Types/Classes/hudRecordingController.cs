using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hudRecordingController : gameuiHUDGameController
	{
		private CWeakHandle<inkCompoundWidget> _root;
		private CHandle<inkanimProxy> _anim_intro;
		private CHandle<inkanimProxy> _anim_outro;
		private CHandle<inkanimProxy> _anim_loop;
		private inkanimPlaybackOptions _option_intro;
		private inkanimPlaybackOptions _option_loop;
		private inkanimPlaybackOptions _option_outro;
		private CUInt32 _factListener;

		[Ordinal(9)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("anim_intro")] 
		public CHandle<inkanimProxy> Anim_intro
		{
			get => GetProperty(ref _anim_intro);
			set => SetProperty(ref _anim_intro, value);
		}

		[Ordinal(11)] 
		[RED("anim_outro")] 
		public CHandle<inkanimProxy> Anim_outro
		{
			get => GetProperty(ref _anim_outro);
			set => SetProperty(ref _anim_outro, value);
		}

		[Ordinal(12)] 
		[RED("anim_loop")] 
		public CHandle<inkanimProxy> Anim_loop
		{
			get => GetProperty(ref _anim_loop);
			set => SetProperty(ref _anim_loop, value);
		}

		[Ordinal(13)] 
		[RED("option_intro")] 
		public inkanimPlaybackOptions Option_intro
		{
			get => GetProperty(ref _option_intro);
			set => SetProperty(ref _option_intro, value);
		}

		[Ordinal(14)] 
		[RED("option_loop")] 
		public inkanimPlaybackOptions Option_loop
		{
			get => GetProperty(ref _option_loop);
			set => SetProperty(ref _option_loop, value);
		}

		[Ordinal(15)] 
		[RED("option_outro")] 
		public inkanimPlaybackOptions Option_outro
		{
			get => GetProperty(ref _option_outro);
			set => SetProperty(ref _option_outro, value);
		}

		[Ordinal(16)] 
		[RED("factListener")] 
		public CUInt32 FactListener
		{
			get => GetProperty(ref _factListener);
			set => SetProperty(ref _factListener, value);
		}
	}
}
