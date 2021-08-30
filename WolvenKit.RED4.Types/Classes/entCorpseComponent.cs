using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entCorpseComponent : entISkinableComponent
	{
		private CHandle<physicsFilterData> _filterData;
		private CName _material;

		[Ordinal(5)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(6)] 
		[RED("material")] 
		public CName Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		public entCorpseComponent()
		{
			_material = "flesh.physmat";
		}
	}
}
