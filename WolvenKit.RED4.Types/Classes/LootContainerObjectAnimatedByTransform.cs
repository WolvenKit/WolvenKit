using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LootContainerObjectAnimatedByTransform : gameContainerObjectBase
	{
		[Ordinal(46)] 
		[RED("wasOpened")] 
		public CBool WasOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
