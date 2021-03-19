using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingEvent : redEvent
	{
		private CHandle<gamemountingMountingRequest> _request;
		private gamemountingMountingRelationship _relationship;

		[Ordinal(0)] 
		[RED("request")] 
		public CHandle<gamemountingMountingRequest> Request
		{
			get => GetProperty(ref _request);
			set => SetProperty(ref _request, value);
		}

		[Ordinal(1)] 
		[RED("relationship")] 
		public gamemountingMountingRelationship Relationship
		{
			get => GetProperty(ref _relationship);
			set => SetProperty(ref _relationship, value);
		}

		public gamemountingMountingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
