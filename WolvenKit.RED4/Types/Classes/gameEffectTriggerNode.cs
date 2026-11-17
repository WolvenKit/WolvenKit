using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectTriggerNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("effectDescs")] 
		public CArray<CHandle<gameEffectTriggerEffectDesc>> EffectDescs
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectTriggerEffectDesc>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectTriggerEffectDesc>>>(value);
		}

		public gameEffectTriggerNode()
		{
			Color = new CColor { Green = 237, Blue = 255, Alpha = 170 };
			EffectDescs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
