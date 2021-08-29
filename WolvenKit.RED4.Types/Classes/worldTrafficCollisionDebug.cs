using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficCollisionDebug : ISerializable
	{
		private CArray<worldDbgOverlapBox> _overlapBoxes;

		[Ordinal(0)] 
		[RED("overlapBoxes")] 
		public CArray<worldDbgOverlapBox> OverlapBoxes
		{
			get => GetProperty(ref _overlapBoxes);
			set => SetProperty(ref _overlapBoxes, value);
		}
	}
}
