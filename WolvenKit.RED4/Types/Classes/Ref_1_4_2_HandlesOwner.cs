using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_4_2_HandlesOwner : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("obj")] 
		public CHandle<Ref_1_4_2_Class> Obj
		{
			get => GetPropertyValue<CHandle<Ref_1_4_2_Class>>();
			set => SetPropertyValue<CHandle<Ref_1_4_2_Class>>(value);
		}

		[Ordinal(1)] 
		[RED("weakObj")] 
		public CWeakHandle<Ref_1_4_2_Class> WeakObj
		{
			get => GetPropertyValue<CWeakHandle<Ref_1_4_2_Class>>();
			set => SetPropertyValue<CWeakHandle<Ref_1_4_2_Class>>(value);
		}

		public Ref_1_4_2_HandlesOwner()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
