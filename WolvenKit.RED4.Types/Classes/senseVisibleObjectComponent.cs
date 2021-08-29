using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseVisibleObjectComponent : entIPlacedComponent
	{
		private CHandle<senseVisibleObject> _visibleObject;

		[Ordinal(5)] 
		[RED("visibleObject")] 
		public CHandle<senseVisibleObject> VisibleObject
		{
			get => GetProperty(ref _visibleObject);
			set => SetProperty(ref _visibleObject, value);
		}
	}
}
