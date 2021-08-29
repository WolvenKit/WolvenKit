using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Target : IScriptable
	{
		private CWeakHandle<gameObject> _target;
		private CBool _isInteresting;
		private CBool _isVisible;

		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target_
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("isInteresting")] 
		public CBool IsInteresting
		{
			get => GetProperty(ref _isInteresting);
			set => SetProperty(ref _isInteresting, value);
		}

		[Ordinal(2)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}
	}
}
