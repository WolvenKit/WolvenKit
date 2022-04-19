using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_RejectOnPrereq : gameEffectObjectSingleFilter
	{
		[Ordinal(0)] 
		[RED("prereq")] 
		public CHandle<gameIPrereq> Prereq
		{
			get => GetPropertyValue<CHandle<gameIPrereq>>();
			set => SetPropertyValue<CHandle<gameIPrereq>>(value);
		}

		public gameEffectObjectFilter_RejectOnPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
