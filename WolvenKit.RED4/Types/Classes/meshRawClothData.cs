using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshRawClothData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("state")] 
		public physicsclothState State
		{
			get => GetPropertyValue<physicsclothState>();
			set => SetPropertyValue<physicsclothState>(value);
		}

		[Ordinal(1)] 
		[RED("maxDistanceChannel")] 
		public CArray<DataBuffer> MaxDistanceChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		[Ordinal(2)] 
		[RED("maxDistanceExtChannel")] 
		public CArray<DataBuffer> MaxDistanceExtChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		[Ordinal(3)] 
		[RED("backstopDistanceChannel")] 
		public CArray<DataBuffer> BackstopDistanceChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		[Ordinal(4)] 
		[RED("backstopRadiusChannel")] 
		public CArray<DataBuffer> BackstopRadiusChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		[Ordinal(5)] 
		[RED("selfCollisionChannel")] 
		public CArray<DataBuffer> SelfCollisionChannel
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		public meshRawClothData()
		{
			State = new physicsclothState();
			MaxDistanceChannel = new();
			MaxDistanceExtChannel = new();
			BackstopDistanceChannel = new();
			BackstopRadiusChannel = new();
			SelfCollisionChannel = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
