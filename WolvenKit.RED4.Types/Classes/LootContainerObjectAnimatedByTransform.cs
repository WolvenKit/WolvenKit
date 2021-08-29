using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LootContainerObjectAnimatedByTransform : gameContainerObjectBase
	{
		private CBool _wasOpened;

		[Ordinal(51)] 
		[RED("wasOpened")] 
		public CBool WasOpened
		{
			get => GetProperty(ref _wasOpened);
			set => SetProperty(ref _wasOpened, value);
		}
	}
}
