using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EntitiesAtGate : MorphData
	{
		[Ordinal(1)] 
		[RED("entitiesAtGate")] 
		public CArray<entEntityID> EntitiesAtGate_
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public EntitiesAtGate()
		{
			EntitiesAtGate_ = new();
		}
	}
}
