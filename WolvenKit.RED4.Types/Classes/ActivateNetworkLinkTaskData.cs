using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivateNetworkLinkTaskData : gameScriptTaskData
	{
		private CInt32 _linkIndex;

		[Ordinal(0)] 
		[RED("linkIndex")] 
		public CInt32 LinkIndex
		{
			get => GetProperty(ref _linkIndex);
			set => SetProperty(ref _linkIndex, value);
		}
	}
}
