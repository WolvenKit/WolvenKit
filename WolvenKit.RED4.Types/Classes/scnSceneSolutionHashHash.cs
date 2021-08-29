using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneSolutionHashHash : RedBaseClass
	{
		private CUInt64 _sceneSolutionHashDate;

		[Ordinal(0)] 
		[RED("sceneSolutionHashDate")] 
		public CUInt64 SceneSolutionHashDate
		{
			get => GetProperty(ref _sceneSolutionHashDate);
			set => SetProperty(ref _sceneSolutionHashDate, value);
		}
	}
}
