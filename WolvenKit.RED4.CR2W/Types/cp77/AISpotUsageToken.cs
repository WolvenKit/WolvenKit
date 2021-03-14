using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpotUsageToken : CVariable
	{
		private worldGlobalNodeID _usedSpotId;
		private entEntityID _spotUserId;

		[Ordinal(0)] 
		[RED("usedSpotId")] 
		public worldGlobalNodeID UsedSpotId
		{
			get
			{
				if (_usedSpotId == null)
				{
					_usedSpotId = (worldGlobalNodeID) CR2WTypeManager.Create("worldGlobalNodeID", "usedSpotId", cr2w, this);
				}
				return _usedSpotId;
			}
			set
			{
				if (_usedSpotId == value)
				{
					return;
				}
				_usedSpotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spotUserId")] 
		public entEntityID SpotUserId
		{
			get
			{
				if (_spotUserId == null)
				{
					_spotUserId = (entEntityID) CR2WTypeManager.Create("entEntityID", "spotUserId", cr2w, this);
				}
				return _spotUserId;
			}
			set
			{
				if (_spotUserId == value)
				{
					return;
				}
				_spotUserId = value;
				PropertySet(this);
			}
		}

		public AISpotUsageToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
