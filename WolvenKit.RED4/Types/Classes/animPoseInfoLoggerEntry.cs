
namespace WolvenKit.RED4.Types
{
	public abstract partial class animPoseInfoLoggerEntry : ISerializable
	{
		public animPoseInfoLoggerEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
