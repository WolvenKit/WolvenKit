using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameComponent : entIComponent
	{
		private CHandle<gamePersistentState> _persistentState;

		[Ordinal(3)] 
		[RED("persistentState")] 
		public CHandle<gamePersistentState> PersistentState
		{
			get => GetProperty(ref _persistentState);
			set => SetProperty(ref _persistentState, value);
		}
	}
}
