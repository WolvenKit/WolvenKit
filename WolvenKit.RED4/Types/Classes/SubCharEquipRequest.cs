using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SubCharEquipRequest : gameEquipRequest
	{
		[Ordinal(5)] 
		[RED("subCharType")] 
		public CEnum<gamedataSubCharacter> SubCharType
		{
			get => GetPropertyValue<CEnum<gamedataSubCharacter>>();
			set => SetPropertyValue<CEnum<gamedataSubCharacter>>(value);
		}

		public SubCharEquipRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
