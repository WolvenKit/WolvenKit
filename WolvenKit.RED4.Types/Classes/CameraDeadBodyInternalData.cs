using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraDeadBodyInternalData : IScriptable
	{
		private entEntityID _ownerID;
		private CArray<entEntityID> _bodyIDs;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(1)] 
		[RED("bodyIDs")] 
		public CArray<entEntityID> BodyIDs
		{
			get => GetProperty(ref _bodyIDs);
			set => SetProperty(ref _bodyIDs, value);
		}
	}
}
