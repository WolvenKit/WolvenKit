using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDestructibleObject : gameObject
	{
		[Ordinal(36)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameDestructibleObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
