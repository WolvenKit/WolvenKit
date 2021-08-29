using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehiclePortalsList : IScriptable
	{
		private CArray<NodeRef> _listPoints;

		[Ordinal(0)] 
		[RED("listPoints")] 
		public CArray<NodeRef> ListPoints
		{
			get => GetProperty(ref _listPoints);
			set => SetProperty(ref _listPoints, value);
		}
	}
}
