using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectTriggerNode : worldAreaShapeNode
	{
		private CArray<CHandle<gameEffectTriggerEffectDesc>> _effectDescs;

		[Ordinal(6)] 
		[RED("effectDescs")] 
		public CArray<CHandle<gameEffectTriggerEffectDesc>> EffectDescs
		{
			get => GetProperty(ref _effectDescs);
			set => SetProperty(ref _effectDescs, value);
		}
	}
}
