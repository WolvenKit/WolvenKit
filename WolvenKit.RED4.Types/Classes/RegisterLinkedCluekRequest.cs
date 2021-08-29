using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterLinkedCluekRequest : gameScriptableSystemRequest
	{
		private LinkedFocusClueData _linkedCluekData;
		private CBool _forceUpdate;

		[Ordinal(0)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetProperty(ref _linkedCluekData);
			set => SetProperty(ref _linkedCluekData, value);
		}

		[Ordinal(1)] 
		[RED("forceUpdate")] 
		public CBool ForceUpdate
		{
			get => GetProperty(ref _forceUpdate);
			set => SetProperty(ref _forceUpdate, value);
		}
	}
}
