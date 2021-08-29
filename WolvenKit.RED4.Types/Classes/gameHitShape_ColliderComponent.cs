using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitShape_ColliderComponent : gameHitShapeBase
	{
		private CArray<CName> _componentNames;

		[Ordinal(3)] 
		[RED("componentNames")] 
		public CArray<CName> ComponentNames
		{
			get => GetProperty(ref _componentNames);
			set => SetProperty(ref _componentNames, value);
		}
	}
}
