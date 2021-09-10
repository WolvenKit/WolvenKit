using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IconsInstance : ModuleInstance
	{
		[Ordinal(6)] 
		[RED("isForcedVisibleThroughWalls")] 
		public CBool IsForcedVisibleThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
