using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workCoverTypeCondition : workIWorkspotCondition
	{
		[Ordinal(2)] 
		[RED("isHighCover")] 
		public CBool IsHighCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public workCoverTypeCondition()
		{
			Equals_ = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
