using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questHackingManager_SetHacked : questHackingManager_ActionType
	{
		private CBool _hacked;

		[Ordinal(0)] 
		[RED("hacked")] 
		public CBool Hacked
		{
			get => GetProperty(ref _hacked);
			set => SetProperty(ref _hacked, value);
		}
	}
}
