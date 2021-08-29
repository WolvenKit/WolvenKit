using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineparameterTypeRequestItem : IScriptable
	{
		private CArray<gameEquipParam> _requests;

		[Ordinal(0)] 
		[RED("requests")] 
		public CArray<gameEquipParam> Requests
		{
			get => GetProperty(ref _requests);
			set => SetProperty(ref _requests, value);
		}
	}
}
