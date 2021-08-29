using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionInteractivityInfo : RedBaseClass
	{
		private CBool _isExternal;
		private CBool _isRemote;
		private CBool _isDirect;

		[Ordinal(0)] 
		[RED("isExternal")] 
		public CBool IsExternal
		{
			get => GetProperty(ref _isExternal);
			set => SetProperty(ref _isExternal, value);
		}

		[Ordinal(1)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get => GetProperty(ref _isRemote);
			set => SetProperty(ref _isRemote, value);
		}

		[Ordinal(2)] 
		[RED("isDirect")] 
		public CBool IsDirect
		{
			get => GetProperty(ref _isDirect);
			set => SetProperty(ref _isDirect, value);
		}
	}
}
