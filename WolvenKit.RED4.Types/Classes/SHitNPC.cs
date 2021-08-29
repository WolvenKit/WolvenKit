using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SHitNPC : RedBaseClass
	{
		private entEntityID _entityID;
		private CInt32 _calls;

		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(1)] 
		[RED("calls")] 
		public CInt32 Calls
		{
			get => GetProperty(ref _calls);
			set => SetProperty(ref _calls, value);
		}
	}
}
