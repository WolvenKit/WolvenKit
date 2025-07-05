
namespace WolvenKit.RED4.Types
{
	public abstract partial class animIStaticCondition : ISerializable
	{
		public animIStaticCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
