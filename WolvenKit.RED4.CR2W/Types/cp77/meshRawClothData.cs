using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshRawClothData : CVariable
	{
		private physicsclothState _state;
		private CArray<DataBuffer> _maxDistanceChannel;
		private CArray<DataBuffer> _maxDistanceExtChannel;
		private CArray<DataBuffer> _backstopDistanceChannel;
		private CArray<DataBuffer> _backstopRadiusChannel;
		private CArray<DataBuffer> _selfCollisionChannel;

		[Ordinal(0)] 
		[RED("state")] 
		public physicsclothState State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("maxDistanceChannel")] 
		public CArray<DataBuffer> MaxDistanceChannel
		{
			get => GetProperty(ref _maxDistanceChannel);
			set => SetProperty(ref _maxDistanceChannel, value);
		}

		[Ordinal(2)] 
		[RED("maxDistanceExtChannel")] 
		public CArray<DataBuffer> MaxDistanceExtChannel
		{
			get => GetProperty(ref _maxDistanceExtChannel);
			set => SetProperty(ref _maxDistanceExtChannel, value);
		}

		[Ordinal(3)] 
		[RED("backstopDistanceChannel")] 
		public CArray<DataBuffer> BackstopDistanceChannel
		{
			get => GetProperty(ref _backstopDistanceChannel);
			set => SetProperty(ref _backstopDistanceChannel, value);
		}

		[Ordinal(4)] 
		[RED("backstopRadiusChannel")] 
		public CArray<DataBuffer> BackstopRadiusChannel
		{
			get => GetProperty(ref _backstopRadiusChannel);
			set => SetProperty(ref _backstopRadiusChannel, value);
		}

		[Ordinal(5)] 
		[RED("selfCollisionChannel")] 
		public CArray<DataBuffer> SelfCollisionChannel
		{
			get => GetProperty(ref _selfCollisionChannel);
			set => SetProperty(ref _selfCollisionChannel, value);
		}

		public meshRawClothData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
