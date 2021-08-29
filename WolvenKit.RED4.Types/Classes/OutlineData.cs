using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OutlineData : RedBaseClass
	{
		private CEnum<EOutlineType> _outlineType;
		private CFloat _outlineStrength;

		[Ordinal(0)] 
		[RED("outlineType")] 
		public CEnum<EOutlineType> OutlineType
		{
			get => GetProperty(ref _outlineType);
			set => SetProperty(ref _outlineType, value);
		}

		[Ordinal(1)] 
		[RED("outlineStrength")] 
		public CFloat OutlineStrength
		{
			get => GetProperty(ref _outlineStrength);
			set => SetProperty(ref _outlineStrength, value);
		}
	}
}
