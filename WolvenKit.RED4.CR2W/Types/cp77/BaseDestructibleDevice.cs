using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseDestructibleDevice : Device
	{
		private CFloat _minTime;
		private CFloat _maxTime;
		private CHandle<entPhysicalMeshComponent> _destroyedMesh;

		[Ordinal(86)] 
		[RED("minTime")] 
		public CFloat MinTime
		{
			get => GetProperty(ref _minTime);
			set => SetProperty(ref _minTime, value);
		}

		[Ordinal(87)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetProperty(ref _maxTime);
			set => SetProperty(ref _maxTime, value);
		}

		[Ordinal(88)] 
		[RED("destroyedMesh")] 
		public CHandle<entPhysicalMeshComponent> DestroyedMesh
		{
			get => GetProperty(ref _destroyedMesh);
			set => SetProperty(ref _destroyedMesh, value);
		}

		public BaseDestructibleDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
