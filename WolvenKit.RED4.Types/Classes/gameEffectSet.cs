using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectSet : CResource
	{
		private CArray<gameEffectDefinition> _effects;

		[Ordinal(1)] 
		[RED("effects")] 
		public CArray<gameEffectDefinition> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}
	}
}
