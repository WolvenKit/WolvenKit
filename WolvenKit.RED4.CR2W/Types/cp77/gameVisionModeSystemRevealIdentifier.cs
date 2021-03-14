using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeSystemRevealIdentifier : CVariable
	{
		private entEntityID _sourceEntityId;
		private CName _reason;

		[Ordinal(0)] 
		[RED("sourceEntityId")] 
		public entEntityID SourceEntityId
		{
			get
			{
				if (_sourceEntityId == null)
				{
					_sourceEntityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "sourceEntityId", cr2w, this);
				}
				return _sourceEntityId;
			}
			set
			{
				if (_sourceEntityId == value)
				{
					return;
				}
				_sourceEntityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CName) CR2WTypeManager.Create("CName", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		public gameVisionModeSystemRevealIdentifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
