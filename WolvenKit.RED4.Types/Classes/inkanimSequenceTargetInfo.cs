using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimSequenceTargetInfo : ISerializable
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CArray<CUInt32> Path
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public inkanimSequenceTargetInfo()
		{
			Path = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
