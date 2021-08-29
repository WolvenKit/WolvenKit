using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetAssessmentRequest : ScriptableDeviceAction
	{
		private CWeakHandle<gameObject> _targetToAssess;

		[Ordinal(25)] 
		[RED("targetToAssess")] 
		public CWeakHandle<gameObject> TargetToAssess
		{
			get => GetProperty(ref _targetToAssess);
			set => SetProperty(ref _targetToAssess, value);
		}
	}
}
