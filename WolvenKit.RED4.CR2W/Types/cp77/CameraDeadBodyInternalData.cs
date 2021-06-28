using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraDeadBodyInternalData : IScriptable
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

		public CameraDeadBodyInternalData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
