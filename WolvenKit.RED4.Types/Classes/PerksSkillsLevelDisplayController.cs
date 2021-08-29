using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksSkillsLevelDisplayController : inkWidgetLogicController
	{
		private inkWidgetReference _tint;

		[Ordinal(1)] 
		[RED("tint")] 
		public inkWidgetReference Tint
		{
			get => GetProperty(ref _tint);
			set => SetProperty(ref _tint, value);
		}
	}
}
