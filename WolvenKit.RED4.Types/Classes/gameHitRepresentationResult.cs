using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitRepresentationResult : RedBaseClass
	{
		private gameQueryResult _sult;
		private entEntityID _tityID;

		[Ordinal(0)] 
		[RED("sult")] 
		public gameQueryResult Sult
		{
			get => GetProperty(ref _sult);
			set => SetProperty(ref _sult, value);
		}

		[Ordinal(1)] 
		[RED("tityID")] 
		public entEntityID TityID
		{
			get => GetProperty(ref _tityID);
			set => SetProperty(ref _tityID, value);
		}
	}
}
