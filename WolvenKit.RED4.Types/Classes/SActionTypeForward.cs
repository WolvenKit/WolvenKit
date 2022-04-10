using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SActionTypeForward : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("qHack")] 
		public CBool QHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("techie")] 
		public CBool Techie
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("master")] 
		public CBool Master
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SActionTypeForward()
		{
			QHack = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
