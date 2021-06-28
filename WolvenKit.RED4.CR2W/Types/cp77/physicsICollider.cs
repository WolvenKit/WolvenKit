using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsICollider : ISerializable
	{
		private Transform _localToBody;
		private CName _material;
		private CArray<physicsApperanceMaterial> _materialApperanceOverrides;
		private CName _tag;
		private CBool _isImported;
		private CBool _isQueryShapeOnly;
		private CFloat _volumeModifier;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(0)] 
		[RED("localToBody")] 
		public Transform LocalToBody
		{
			get => GetProperty(ref _localToBody);
			set => SetProperty(ref _localToBody, value);
		}

		[Ordinal(1)] 
		[RED("material")] 
		public CName Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		[Ordinal(2)] 
		[RED("materialApperanceOverrides")] 
		public CArray<physicsApperanceMaterial> MaterialApperanceOverrides
		{
			get => GetProperty(ref _materialApperanceOverrides);
			set => SetProperty(ref _materialApperanceOverrides, value);
		}

		[Ordinal(3)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(4)] 
		[RED("isImported")] 
		public CBool IsImported
		{
			get => GetProperty(ref _isImported);
			set => SetProperty(ref _isImported, value);
		}

		[Ordinal(5)] 
		[RED("isQueryShapeOnly")] 
		public CBool IsQueryShapeOnly
		{
			get => GetProperty(ref _isQueryShapeOnly);
			set => SetProperty(ref _isQueryShapeOnly, value);
		}

		[Ordinal(6)] 
		[RED("volumeModifier")] 
		public CFloat VolumeModifier
		{
			get => GetProperty(ref _volumeModifier);
			set => SetProperty(ref _volumeModifier, value);
		}

		[Ordinal(7)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		public physicsICollider(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
