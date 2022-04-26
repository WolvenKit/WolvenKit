using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnActorRid : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get => GetPropertyValue<scnRidTag>();
			set => SetPropertyValue<scnRidTag>(value);
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<scnAnimationRid> Animations
		{
			get => GetPropertyValue<CArray<scnAnimationRid>>();
			set => SetPropertyValue<CArray<scnAnimationRid>>(value);
		}

		[Ordinal(2)] 
		[RED("facialAnimations")] 
		public CArray<scnAnimationRid> FacialAnimations
		{
			get => GetPropertyValue<CArray<scnAnimationRid>>();
			set => SetPropertyValue<CArray<scnAnimationRid>>(value);
		}

		[Ordinal(3)] 
		[RED("cyberwareAnimations")] 
		public CArray<scnAnimationRid> CyberwareAnimations
		{
			get => GetPropertyValue<CArray<scnAnimationRid>>();
			set => SetPropertyValue<CArray<scnAnimationRid>>(value);
		}

		public scnActorRid()
		{
			Tag = new() { SerialNumber = new() { SerialNumber = 4294967295 } };
			Animations = new();
			FacialAnimations = new();
			CyberwareAnimations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
