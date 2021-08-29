using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProtectedEntities : MorphData
	{
		private CArray<entEntityID> _protectedEntities;

		[Ordinal(1)] 
		[RED("protectedEntities")] 
		public CArray<entEntityID> ProtectedEntities_
		{
			get => GetProperty(ref _protectedEntities);
			set => SetProperty(ref _protectedEntities, value);
		}
	}
}
