using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckStimTag : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("stimTagToCompare")] 
		public CArray<CName> StimTagToCompare
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public CheckStimTag()
		{
			StimTagToCompare = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
