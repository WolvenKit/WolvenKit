using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingUnmountingEvent : redEvent
	{
		private CHandle<gamemountingUnmountingRequest> _request;
		private gamemountingMountingRelationship _relationship;

		[Ordinal(0)] 
		[RED("request")] 
		public CHandle<gamemountingUnmountingRequest> Request
		{
			get
			{
				if (_request == null)
				{
					_request = (CHandle<gamemountingUnmountingRequest>) CR2WTypeManager.Create("handle:gamemountingUnmountingRequest", "request", cr2w, this);
				}
				return _request;
			}
			set
			{
				if (_request == value)
				{
					return;
				}
				_request = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("relationship")] 
		public gamemountingMountingRelationship Relationship
		{
			get
			{
				if (_relationship == null)
				{
					_relationship = (gamemountingMountingRelationship) CR2WTypeManager.Create("gamemountingMountingRelationship", "relationship", cr2w, this);
				}
				return _relationship;
			}
			set
			{
				if (_relationship == value)
				{
					return;
				}
				_relationship = value;
				PropertySet(this);
			}
		}

		public gamemountingUnmountingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
