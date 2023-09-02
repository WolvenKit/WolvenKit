using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class physicsICollider : ISerializable
	{
		[Ordinal(0)] 
		[RED("localToBody")] 
		public Transform LocalToBody
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(1)] 
		[RED("material")] 
		public CName Material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("materialApperanceOverrides")] 
		public CArray<physicsApperanceMaterial> MaterialApperanceOverrides
		{
			get => GetPropertyValue<CArray<physicsApperanceMaterial>>();
			set => SetPropertyValue<CArray<physicsApperanceMaterial>>(value);
		}

		[Ordinal(3)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("isImported")] 
		public CBool IsImported
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isQueryShapeOnly")] 
		public CBool IsQueryShapeOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("volumeModifier")] 
		public CFloat VolumeModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		public physicsICollider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
