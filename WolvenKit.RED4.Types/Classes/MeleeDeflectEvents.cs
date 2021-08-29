using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeDeflectEvents : MeleeEventsTransition
	{
		private CHandle<gameStatModifierData_Deprecated> _deflectStatFlag;

		[Ordinal(0)] 
		[RED("deflectStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> DeflectStatFlag
		{
			get => GetProperty(ref _deflectStatFlag);
			set => SetProperty(ref _deflectStatFlag, value);
		}
	}
}
