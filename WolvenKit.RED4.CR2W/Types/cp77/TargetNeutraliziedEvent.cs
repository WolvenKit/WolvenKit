using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetNeutraliziedEvent : redEvent
	{
		private CEnum<ENeutralizeType> _type;
		private entEntityID _targetID;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<ENeutralizeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<ENeutralizeType>) CR2WTypeManager.Create("ENeutralizeType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		public TargetNeutraliziedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
