using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_DisableSleepMode : animAnimNode_OnePoseInput
	{
		private CBool _forceUpdate;

		[Ordinal(12)] 
		[RED("forceUpdate")] 
		public CBool ForceUpdate
		{
			get => GetProperty(ref _forceUpdate);
			set => SetProperty(ref _forceUpdate, value);
		}
	}
}
