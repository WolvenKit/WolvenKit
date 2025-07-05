
namespace WolvenKit.RED4.Types
{
	public abstract partial class QuicksortTemplate : IScriptable
	{
		public QuicksortTemplate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
