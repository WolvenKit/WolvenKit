using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectInfo : CVariable
	{
		private CArray<CName> _placementTags;
		private CArray<CName> _componentNames;
		private CArray<Vector3> _relativePositions;
		private CArray<Quaternion> _relativeRotations;
		private CArray<worldCompiledEffectPlacementInfo> _placementInfos;
		private CArray<worldCompiledEffectEventInfo> _eventsSortedByRUID;

		[Ordinal(0)] 
		[RED("placementTags")] 
		public CArray<CName> PlacementTags
		{
			get => GetProperty(ref _placementTags);
			set => SetProperty(ref _placementTags, value);
		}

		[Ordinal(1)] 
		[RED("componentNames")] 
		public CArray<CName> ComponentNames
		{
			get => GetProperty(ref _componentNames);
			set => SetProperty(ref _componentNames, value);
		}

		[Ordinal(2)] 
		[RED("relativePositions")] 
		public CArray<Vector3> RelativePositions
		{
			get => GetProperty(ref _relativePositions);
			set => SetProperty(ref _relativePositions, value);
		}

		[Ordinal(3)] 
		[RED("relativeRotations")] 
		public CArray<Quaternion> RelativeRotations
		{
			get => GetProperty(ref _relativeRotations);
			set => SetProperty(ref _relativeRotations, value);
		}

		[Ordinal(4)] 
		[RED("placementInfos")] 
		public CArray<worldCompiledEffectPlacementInfo> PlacementInfos
		{
			get => GetProperty(ref _placementInfos);
			set => SetProperty(ref _placementInfos, value);
		}

		[Ordinal(5)] 
		[RED("eventsSortedByRUID")] 
		public CArray<worldCompiledEffectEventInfo> EventsSortedByRUID
		{
			get => GetProperty(ref _eventsSortedByRUID);
			set => SetProperty(ref _eventsSortedByRUID, value);
		}

		public worldCompiledEffectInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
