using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseSimpleBox : senseIShape
	{
		private Box _box;

		[Ordinal(1)] 
		[RED("box")] 
		public Box Box
		{
			get => GetProperty(ref _box);
			set => SetProperty(ref _box, value);
		}
	}
}
