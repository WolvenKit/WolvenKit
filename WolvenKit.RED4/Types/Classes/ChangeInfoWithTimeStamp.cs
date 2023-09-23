using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeInfoWithTimeStamp : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("TimeStamp")] 
		public CFloat TimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("Change")] 
		public CFloat Change
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ChangeInfoWithTimeStamp()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
