using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AutocraftDeactivateRequest : gameScriptableSystemRequest
	{
		private CBool _resetMemory;

		[Ordinal(0)] 
		[RED("resetMemory")] 
		public CBool ResetMemory
		{
			get => GetProperty(ref _resetMemory);
			set => SetProperty(ref _resetMemory, value);
		}
	}
}
