using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LootingScrollBlockController : IScriptable
	{
		private inkWidgetReference _rectangle;

		[Ordinal(0)] 
		[RED("rectangle")] 
		public inkWidgetReference Rectangle
		{
			get => GetProperty(ref _rectangle);
			set => SetProperty(ref _rectangle, value);
		}
	}
}
