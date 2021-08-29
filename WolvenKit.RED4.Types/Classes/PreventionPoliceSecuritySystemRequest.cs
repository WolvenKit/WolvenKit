using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionPoliceSecuritySystemRequest : gameScriptableSystemRequest
	{
		private gamePersistentID _securitySystemID;

		[Ordinal(0)] 
		[RED("securitySystemID")] 
		public gamePersistentID SecuritySystemID
		{
			get => GetProperty(ref _securitySystemID);
			set => SetProperty(ref _securitySystemID, value);
		}
	}
}
