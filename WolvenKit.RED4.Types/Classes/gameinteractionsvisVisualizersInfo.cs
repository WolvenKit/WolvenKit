using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisVisualizersInfo : RedBaseClass
	{
		private CInt32 _activeVisId;
		private CArray<CInt32> _visIds;

		[Ordinal(0)] 
		[RED("activeVisId")] 
		public CInt32 ActiveVisId
		{
			get => GetProperty(ref _activeVisId);
			set => SetProperty(ref _activeVisId, value);
		}

		[Ordinal(1)] 
		[RED("visIds")] 
		public CArray<CInt32> VisIds
		{
			get => GetProperty(ref _visIds);
			set => SetProperty(ref _visIds, value);
		}

		public gameinteractionsvisVisualizersInfo()
		{
			_activeVisId = -1;
		}
	}
}
