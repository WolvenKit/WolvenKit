using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Retarget : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("refRig")] 
		public CResourceReference<animRig> RefRig
		{
			get => GetPropertyValue<CResourceReference<animRig>>();
			set => SetPropertyValue<CResourceReference<animRig>>(value);
		}

		[Ordinal(13)] 
		[RED("postProcess")] 
		public CHandle<animIAnimNode_PostProcess> PostProcess
		{
			get => GetPropertyValue<CHandle<animIAnimNode_PostProcess>>();
			set => SetPropertyValue<CHandle<animIAnimNode_PostProcess>>(value);
		}

		public animAnimNode_Retarget()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
