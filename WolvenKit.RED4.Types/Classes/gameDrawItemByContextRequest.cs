using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDrawItemByContextRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemEquipContext")] 
		public CEnum<gameItemEquipContexts> ItemEquipContext
		{
			get => GetPropertyValue<CEnum<gameItemEquipContexts>>();
			set => SetPropertyValue<CEnum<gameItemEquipContexts>>(value);
		}

		[Ordinal(2)] 
		[RED("equipAnimationType")] 
		public CEnum<gameEquipAnimationType> EquipAnimationType
		{
			get => GetPropertyValue<CEnum<gameEquipAnimationType>>();
			set => SetPropertyValue<CEnum<gameEquipAnimationType>>(value);
		}

		public gameDrawItemByContextRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
