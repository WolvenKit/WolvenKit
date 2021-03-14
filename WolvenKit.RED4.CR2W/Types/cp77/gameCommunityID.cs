using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCommunityID : CVariable
	{
		private entEntityID _entityId;

		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get
			{
				if (_entityId == null)
				{
					_entityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityId", cr2w, this);
				}
				return _entityId;
			}
			set
			{
				if (_entityId == value)
				{
					return;
				}
				_entityId = value;
				PropertySet(this);
			}
		}

		public gameCommunityID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
