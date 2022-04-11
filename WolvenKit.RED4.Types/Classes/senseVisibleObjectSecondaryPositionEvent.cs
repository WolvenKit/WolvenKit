using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseVisibleObjectSecondaryPositionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public senseVisibleObjectSecondaryPositionEvent()
		{
			Offset = new();
		}
	}
}
