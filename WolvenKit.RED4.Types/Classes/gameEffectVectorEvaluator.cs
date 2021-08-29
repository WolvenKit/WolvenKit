using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectVectorEvaluator : ISerializable
	{
		private CFloat _modifier;

		[Ordinal(0)] 
		[RED("modifier")] 
		public CFloat Modifier
		{
			get => GetProperty(ref _modifier);
			set => SetProperty(ref _modifier, value);
		}
	}
}
