using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldRoadMaterialInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startOffset")] 
		public CFloat StartOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("material")] 
		public CEnum<worldRoadMaterial> Material
		{
			get => GetPropertyValue<CEnum<worldRoadMaterial>>();
			set => SetPropertyValue<CEnum<worldRoadMaterial>>(value);
		}

		public worldRoadMaterialInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
