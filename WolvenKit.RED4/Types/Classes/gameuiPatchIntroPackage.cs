using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPatchIntroPackage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("patchIntrosNeeded")] 
		public CArray<CEnum<gameuiPatchIntro>> PatchIntrosNeeded
		{
			get => GetPropertyValue<CArray<CEnum<gameuiPatchIntro>>>();
			set => SetPropertyValue<CArray<CEnum<gameuiPatchIntro>>>(value);
		}

		public gameuiPatchIntroPackage()
		{
			PatchIntrosNeeded = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
