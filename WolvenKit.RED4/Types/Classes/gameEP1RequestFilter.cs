using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEP1RequestFilter : gameCustomRequestFilter
	{
		[Ordinal(0)] 
		[RED("isEP1")] 
		public CBool IsEP1
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEP1RequestFilter()
		{
			IsEP1 = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
