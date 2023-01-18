using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectExecutor_GameObjectOutline : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("outlineType")] 
		public CEnum<EOutlineType> OutlineType
		{
			get => GetPropertyValue<CEnum<EOutlineType>>();
			set => SetPropertyValue<CEnum<EOutlineType>>(value);
		}

		public EffectExecutor_GameObjectOutline()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
