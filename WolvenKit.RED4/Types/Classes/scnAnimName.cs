using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAnimName : ISerializable
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnAnimNameType> Type
		{
			get => GetPropertyValue<CEnum<scnAnimNameType>>();
			set => SetPropertyValue<CEnum<scnAnimNameType>>(value);
		}

		public scnAnimName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
