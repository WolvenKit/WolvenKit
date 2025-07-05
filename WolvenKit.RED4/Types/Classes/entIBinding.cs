using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class entIBinding : ISerializable
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("enableMask")] 
		public entTagMask EnableMask
		{
			get => GetPropertyValue<entTagMask>();
			set => SetPropertyValue<entTagMask>(value);
		}

		[Ordinal(2)] 
		[RED("bindName")] 
		public CName BindName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entIBinding()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
