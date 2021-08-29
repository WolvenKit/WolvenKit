using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LineSpawnData : IScriptable
	{
		private scnDialogLineData _lineData;

		[Ordinal(0)] 
		[RED("lineData")] 
		public scnDialogLineData LineData
		{
			get => GetProperty(ref _lineData);
			set => SetProperty(ref _lineData, value);
		}
	}
}
