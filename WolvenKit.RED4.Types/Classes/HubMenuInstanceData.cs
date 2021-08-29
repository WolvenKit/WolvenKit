using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HubMenuInstanceData : IScriptable
	{
		private CUInt32 _iD;

		[Ordinal(0)] 
		[RED("ID")] 
		public CUInt32 ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}
	}
}
