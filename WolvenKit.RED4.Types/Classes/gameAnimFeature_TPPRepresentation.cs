using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAnimFeature_TPPRepresentation : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("IsActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameAnimFeature_TPPRepresentation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
