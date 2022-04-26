using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OutlineData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("outlineType")] 
		public CEnum<EOutlineType> OutlineType
		{
			get => GetPropertyValue<CEnum<EOutlineType>>();
			set => SetPropertyValue<CEnum<EOutlineType>>(value);
		}

		[Ordinal(1)] 
		[RED("outlineOpacity")] 
		public CFloat OutlineOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public OutlineData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
