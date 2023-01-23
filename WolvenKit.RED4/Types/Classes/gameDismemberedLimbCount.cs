using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDismemberedLimbCount : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("fleshDismemberments")] 
		public CUInt32 FleshDismemberments
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("cyberDismemberments")] 
		public CUInt32 CyberDismemberments
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameDismemberedLimbCount()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
