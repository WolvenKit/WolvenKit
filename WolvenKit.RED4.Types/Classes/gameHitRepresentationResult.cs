using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Sult = new() { HitShapes = new() };
			TityID = new();
		}
	}
}
