using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LootingScrollBlockController : IScriptable
	{
		[Ordinal(0)] 
		[RED("rectangle")] 
		public inkWidgetReference Rectangle
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public LootingScrollBlockController()
		{
			Rectangle = new();
		}
	}
}
