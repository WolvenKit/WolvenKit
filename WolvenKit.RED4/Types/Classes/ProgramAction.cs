
namespace WolvenKit.RED4.Types
{
	public abstract partial class ProgramAction : ActionBool
	{
		public ProgramAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
