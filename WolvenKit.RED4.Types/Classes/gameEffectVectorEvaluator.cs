using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectVectorEvaluator : ISerializable
	{
		[Ordinal(0)] 
		[RED("modifier")] 
		public CFloat Modifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
