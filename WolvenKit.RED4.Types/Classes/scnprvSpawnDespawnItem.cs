using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnprvSpawnDespawnItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("finalTransform")] 
		public Transform FinalTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public scnprvSpawnDespawnItem()
		{
			FinalTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
		}
	}
}
