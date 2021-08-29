using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEditorDebugFilterSettings_NodeConditional : worldEditorDebugFilterSettings
	{
		private CBool _isDiscarded;
		private CBool _isProxyDependencyModeAutoSet;
		private CBool _isProxyDependencyModeDiscardedSet;

		[Ordinal(0)] 
		[RED("isDiscarded")] 
		public CBool IsDiscarded
		{
			get => GetProperty(ref _isDiscarded);
			set => SetProperty(ref _isDiscarded, value);
		}

		[Ordinal(1)] 
		[RED("isProxyDependencyModeAutoSet")] 
		public CBool IsProxyDependencyModeAutoSet
		{
			get => GetProperty(ref _isProxyDependencyModeAutoSet);
			set => SetProperty(ref _isProxyDependencyModeAutoSet, value);
		}

		[Ordinal(2)] 
		[RED("isProxyDependencyModeDiscardedSet")] 
		public CBool IsProxyDependencyModeDiscardedSet
		{
			get => GetProperty(ref _isProxyDependencyModeDiscardedSet);
			set => SetProperty(ref _isProxyDependencyModeDiscardedSet, value);
		}
	}
}
