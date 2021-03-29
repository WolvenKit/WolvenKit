using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entPhysicalSkinnedMeshComponent : entSkinnedMeshComponent
	{
		private CEnum<physicsSimulationType> _simulationType;
		private CBool _useResourceSimulationType;
		private CBool _startInactive;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(22)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetProperty(ref _simulationType);
			set => SetProperty(ref _simulationType, value);
		}

		[Ordinal(23)] 
		[RED("useResourceSimulationType")] 
		public CBool UseResourceSimulationType
		{
			get => GetProperty(ref _useResourceSimulationType);
			set => SetProperty(ref _useResourceSimulationType, value);
		}

		[Ordinal(24)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetProperty(ref _startInactive);
			set => SetProperty(ref _startInactive, value);
		}

		[Ordinal(25)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetProperty(ref _filterDataSource);
			set => SetProperty(ref _filterDataSource, value);
		}

		[Ordinal(26)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		public entPhysicalSkinnedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
