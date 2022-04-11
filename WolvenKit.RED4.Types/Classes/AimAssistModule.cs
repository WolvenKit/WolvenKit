using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AimAssistModule : HUDModule
	{
		[Ordinal(3)] 
		[RED("activeAssists")] 
		public CArray<CHandle<AimAssist>> ActiveAssists
		{
			get => GetPropertyValue<CArray<CHandle<AimAssist>>>();
			set => SetPropertyValue<CArray<CHandle<AimAssist>>>(value);
		}

		public AimAssistModule()
		{
			InstancesList = new();
			ActiveAssists = new();
		}
	}
}
