using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVisualControllerComponent : entIComponent
	{
		private rRef<CMesh> _meshProxy;
		private CArray<entVisualControllerDependency> _appearanceDependency;
		private raRef<appearanceCookedAppearanceData> _cookedAppearanceData;
		private CEnum<entVisualControllerComponentForcedLodDistance> _forcedLodDistance;

		[Ordinal(3)] 
		[RED("meshProxy")] 
		public rRef<CMesh> MeshProxy
		{
			get => GetProperty(ref _meshProxy);
			set => SetProperty(ref _meshProxy, value);
		}

		[Ordinal(4)] 
		[RED("appearanceDependency")] 
		public CArray<entVisualControllerDependency> AppearanceDependency
		{
			get => GetProperty(ref _appearanceDependency);
			set => SetProperty(ref _appearanceDependency, value);
		}

		[Ordinal(5)] 
		[RED("cookedAppearanceData")] 
		public raRef<appearanceCookedAppearanceData> CookedAppearanceData
		{
			get => GetProperty(ref _cookedAppearanceData);
			set => SetProperty(ref _cookedAppearanceData, value);
		}

		[Ordinal(6)] 
		[RED("forcedLodDistance")] 
		public CEnum<entVisualControllerComponentForcedLodDistance> ForcedLodDistance
		{
			get => GetProperty(ref _forcedLodDistance);
			set => SetProperty(ref _forcedLodDistance, value);
		}

		public entVisualControllerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
