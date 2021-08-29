using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPauseTime_NodeType : questITimeManagerNodeType
	{
		private CBool _pause;
		private CName _source;

		[Ordinal(0)] 
		[RED("pause")] 
		public CBool Pause
		{
			get => GetProperty(ref _pause);
			set => SetProperty(ref _pause, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}
	}
}
