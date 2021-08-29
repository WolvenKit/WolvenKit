using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneSolutionHash : RedBaseClass
	{
		private scnSceneSolutionHashHash _sceneSolutionHash;

		[Ordinal(0)] 
		[RED("sceneSolutionHash")] 
		public scnSceneSolutionHashHash SceneSolutionHash
		{
			get => GetProperty(ref _sceneSolutionHash);
			set => SetProperty(ref _sceneSolutionHash, value);
		}
	}
}
