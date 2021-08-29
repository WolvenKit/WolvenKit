using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class enteventsEntityResize : redEvent
	{
		private Vector3 _extents;

		[Ordinal(0)] 
		[RED("extents")] 
		public Vector3 Extents
		{
			get => GetProperty(ref _extents);
			set => SetProperty(ref _extents, value);
		}
	}
}
