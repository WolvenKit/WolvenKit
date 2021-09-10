using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProtectedEntities : MorphData
	{
		[Ordinal(1)] 
		[RED("protectedEntities")] 
		public CArray<entEntityID> ProtectedEntities_
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public ProtectedEntities()
		{
			ProtectedEntities_ = new();
		}
	}
}
