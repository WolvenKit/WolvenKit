using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InputContextSystem : gameScriptableSystem
	{
		private CEnum<inputContextType> _activeContext;

		[Ordinal(0)] 
		[RED("activeContext")] 
		public CEnum<inputContextType> ActiveContext
		{
			get => GetProperty(ref _activeContext);
			set => SetProperty(ref _activeContext, value);
		}
	}
}
