using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficCollisionDebug : ISerializable
	{
		[Ordinal(0)] 
		[RED("overlapBoxes")] 
		public CArray<worldDbgOverlapBox> OverlapBoxes
		{
			get => GetPropertyValue<CArray<worldDbgOverlapBox>>();
			set => SetPropertyValue<CArray<worldDbgOverlapBox>>(value);
		}

		public worldTrafficCollisionDebug()
		{
			OverlapBoxes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
