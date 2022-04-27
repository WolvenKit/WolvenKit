using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectTriggerNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("effectDescs")] 
		public CArray<CHandle<gameEffectTriggerEffectDesc>> EffectDescs
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectTriggerEffectDesc>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectTriggerEffectDesc>>>(value);
		}

		public gameEffectTriggerNode()
		{
			EffectDescs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
