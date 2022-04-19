using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileHitEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hitInstances")] 
		public CArray<gameprojectileHitInstance> HitInstances
		{
			get => GetPropertyValue<CArray<gameprojectileHitInstance>>();
			set => SetPropertyValue<CArray<gameprojectileHitInstance>>(value);
		}

		public gameprojectileHitEvent()
		{
			HitInstances = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
