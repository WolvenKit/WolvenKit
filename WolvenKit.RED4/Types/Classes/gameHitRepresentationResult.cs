using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitRepresentationResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sult")] 
		public gameQueryResult Sult
		{
			get => GetPropertyValue<gameQueryResult>();
			set => SetPropertyValue<gameQueryResult>(value);
		}

		[Ordinal(1)] 
		[RED("tityID")] 
		public entEntityID TityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public gameHitRepresentationResult()
		{
			Sult = new gameQueryResult { HitShapes = new() };
			TityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
