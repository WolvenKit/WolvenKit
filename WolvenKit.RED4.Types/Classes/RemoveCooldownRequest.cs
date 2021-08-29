using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveCooldownRequest : gameScriptableSystemRequest
	{
		private CInt32 _cid;

		[Ordinal(0)] 
		[RED("cid")] 
		public CInt32 Cid
		{
			get => GetProperty(ref _cid);
			set => SetProperty(ref _cid, value);
		}
	}
}
