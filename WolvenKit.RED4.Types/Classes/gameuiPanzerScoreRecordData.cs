using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPanzerScoreRecordData : RedBaseClass
	{
		private CString _name;
		private CUInt32 _score;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("score")] 
		public CUInt32 Score
		{
			get => GetProperty(ref _score);
			set => SetProperty(ref _score, value);
		}
	}
}
