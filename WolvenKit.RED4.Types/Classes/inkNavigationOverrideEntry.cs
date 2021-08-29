using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkNavigationOverrideEntry : RedBaseClass
	{
		private inkWidgetReference _from;
		private CEnum<inkDiscreteNavigationDirection> _direction;
		private inkWidgetReference _to;

		[Ordinal(0)] 
		[RED("from")] 
		public inkWidgetReference From
		{
			get => GetProperty(ref _from);
			set => SetProperty(ref _from, value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<inkDiscreteNavigationDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(2)] 
		[RED("to")] 
		public inkWidgetReference To
		{
			get => GetProperty(ref _to);
			set => SetProperty(ref _to, value);
		}
	}
}
