using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEffectSpawnerComponent : entIVisualComponent
	{
		private CArray<CHandle<entEffectDesc>> _effectDescs;

		[Ordinal(8)] 
		[RED("effectDescs")] 
		public CArray<CHandle<entEffectDesc>> EffectDescs
		{
			get => GetProperty(ref _effectDescs);
			set => SetProperty(ref _effectDescs, value);
		}
	}
}
