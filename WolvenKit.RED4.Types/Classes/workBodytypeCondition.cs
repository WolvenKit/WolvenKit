using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workBodytypeCondition : workIWorkspotCondition
	{
		[Ordinal(2)] 
		[RED("rig")] 
		public CResourceAsyncReference<animRig> Rig
		{
			get => GetPropertyValue<CResourceAsyncReference<animRig>>();
			set => SetPropertyValue<CResourceAsyncReference<animRig>>(value);
		}

		public workBodytypeCondition()
		{
			Equals_ = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
