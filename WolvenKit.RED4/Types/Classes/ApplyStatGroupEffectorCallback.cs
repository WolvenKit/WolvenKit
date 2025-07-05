using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyStatGroupEffectorCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("effector")] 
		public CHandle<ApplyStatGroupEffector> Effector
		{
			get => GetPropertyValue<CHandle<ApplyStatGroupEffector>>();
			set => SetPropertyValue<CHandle<ApplyStatGroupEffector>>(value);
		}

		public ApplyStatGroupEffectorCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
