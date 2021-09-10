using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectSet : CResource
	{
		[Ordinal(1)] 
		[RED("effects")] 
		public CArray<gameEffectDefinition> Effects
		{
			get => GetPropertyValue<CArray<gameEffectDefinition>>();
			set => SetPropertyValue<CArray<gameEffectDefinition>>(value);
		}

		public gameEffectSet()
		{
			Effects = new();
		}
	}
}
