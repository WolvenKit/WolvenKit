using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SSFXOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<EEffectOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<EEffectOperationType>>();
			set => SetPropertyValue<CEnum<EEffectOperationType>>(value);
		}

		public SSFXOperationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
