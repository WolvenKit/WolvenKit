using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IconsInstance : ModuleInstance
	{
		private CBool _isForcedVisibleThroughWalls;

		[Ordinal(6)] 
		[RED("isForcedVisibleThroughWalls")] 
		public CBool IsForcedVisibleThroughWalls
		{
			get => GetProperty(ref _isForcedVisibleThroughWalls);
			set => SetProperty(ref _isForcedVisibleThroughWalls, value);
		}
	}
}
