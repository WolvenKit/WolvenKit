using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentWoundConfig : ISerializable
	{
		[Ordinal(0)] 
		[RED("WoundName")] 
		public CName WoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("ResourceSet")] 
		public CEnum<entdismembermentResourceSetE> ResourceSet
		{
			get => GetPropertyValue<CEnum<entdismembermentResourceSetE>>();
			set => SetPropertyValue<CEnum<entdismembermentResourceSetE>>(value);
		}

		public entdismembermentWoundConfig()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
