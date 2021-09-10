using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectCarrierComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("objectToSpawn")] 
		public TweakDBID ObjectToSpawn
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameObjectCarrierComponent()
		{
			Name = "Component";
		}
	}
}
