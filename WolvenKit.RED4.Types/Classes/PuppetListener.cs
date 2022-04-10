using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PuppetListener : IScriptable
	{
		[Ordinal(0)] 
		[RED("prereqOwner")] 
		public CHandle<gamePrereqState> PrereqOwner
		{
			get => GetPropertyValue<CHandle<gamePrereqState>>();
			set => SetPropertyValue<CHandle<gamePrereqState>>(value);
		}

		public PuppetListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
