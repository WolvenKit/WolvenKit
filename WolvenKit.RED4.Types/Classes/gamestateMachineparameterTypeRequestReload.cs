using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineparameterTypeRequestReload : IScriptable
	{
		private CWeakHandle<gameItemObject> _item;

		[Ordinal(0)] 
		[RED("item")] 
		public CWeakHandle<gameItemObject> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}
	}
}
