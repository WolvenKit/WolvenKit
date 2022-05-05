using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navSerializableSplineProgression : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sectionIdx")] 
		public CUInt32 SectionIdx
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public navSerializableSplineProgression()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
