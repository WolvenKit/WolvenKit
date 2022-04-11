using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFxResource : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}
	}
}
