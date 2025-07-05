using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePrereqsResource : CResource
	{
		[Ordinal(1)] 
		[RED("prereqs")] 
		public CArray<gamePrereqDefinition> Prereqs
		{
			get => GetPropertyValue<CArray<gamePrereqDefinition>>();
			set => SetPropertyValue<CArray<gamePrereqDefinition>>(value);
		}

		public gamePrereqsResource()
		{
			Prereqs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
