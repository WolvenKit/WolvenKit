using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAreaEvent : ActionBool
	{
		private SecurityAreaData _securityAreaData;
		private CWeakHandle<gameObject> _whoBreached;

		[Ordinal(25)] 
		[RED("securityAreaData")] 
		public SecurityAreaData SecurityAreaData
		{
			get => GetProperty(ref _securityAreaData);
			set => SetProperty(ref _securityAreaData, value);
		}

		[Ordinal(26)] 
		[RED("whoBreached")] 
		public CWeakHandle<gameObject> WhoBreached
		{
			get => GetProperty(ref _whoBreached);
			set => SetProperty(ref _whoBreached, value);
		}
	}
}
