using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIMoveCommand : AICommand
	{
		private CBool _removeAfterCombat;
		private CBool _ignoreInCombat;
		private CBool _alwaysUseStealth;

		[Ordinal(4)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get => GetProperty(ref _removeAfterCombat);
			set => SetProperty(ref _removeAfterCombat, value);
		}

		[Ordinal(5)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get => GetProperty(ref _ignoreInCombat);
			set => SetProperty(ref _ignoreInCombat, value);
		}

		[Ordinal(6)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get => GetProperty(ref _alwaysUseStealth);
			set => SetProperty(ref _alwaysUseStealth, value);
		}
	}
}
