using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseDestructibleDevice : Device
	{
		private CFloat _minTime;
		private CFloat _maxTime;
		private CHandle<entPhysicalMeshComponent> _destroyedMesh;

		[Ordinal(87)] 
		[RED("minTime")] 
		public CFloat MinTime
		{
			get => GetProperty(ref _minTime);
			set => SetProperty(ref _minTime, value);
		}

		[Ordinal(88)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetProperty(ref _maxTime);
			set => SetProperty(ref _maxTime, value);
		}

		[Ordinal(89)] 
		[RED("destroyedMesh")] 
		public CHandle<entPhysicalMeshComponent> DestroyedMesh
		{
			get => GetProperty(ref _destroyedMesh);
			set => SetProperty(ref _destroyedMesh, value);
		}
	}
}
