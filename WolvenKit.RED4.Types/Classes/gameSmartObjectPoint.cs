using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectPoint : RedBaseClass
	{
		private CBool _isReachable;

		[Ordinal(0)] 
		[RED("isReachable")] 
		public CBool IsReachable
		{
			get => GetProperty(ref _isReachable);
			set => SetProperty(ref _isReachable, value);
		}
	}
}
