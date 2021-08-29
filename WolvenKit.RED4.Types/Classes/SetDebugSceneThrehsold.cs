using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetDebugSceneThrehsold : gameScriptableSystemRequest
	{
		private CInt32 _newThreshold;

		[Ordinal(0)] 
		[RED("newThreshold")] 
		public CInt32 NewThreshold
		{
			get => GetProperty(ref _newThreshold);
			set => SetProperty(ref _newThreshold, value);
		}
	}
}
