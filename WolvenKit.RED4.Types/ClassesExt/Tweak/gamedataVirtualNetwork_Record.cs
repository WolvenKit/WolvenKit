
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVirtualNetwork_Record
	{
		[RED("minDistanceToOther")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDistanceToOther
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("offsetMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat OffsetMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("paths")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Paths
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("scale")]
		[REDProperty(IsIgnored = true)]
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("segmentMarker")]
		[REDProperty(IsIgnored = true)]
		public Vector3 SegmentMarker
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
	}
}
