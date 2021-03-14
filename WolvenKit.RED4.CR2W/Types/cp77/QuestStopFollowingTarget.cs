using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestStopFollowingTarget : ActionBool
	{
		private entEntityID _targetEntityID;

		[Ordinal(25)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get
			{
				if (_targetEntityID == null)
				{
					_targetEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetEntityID", cr2w, this);
				}
				return _targetEntityID;
			}
			set
			{
				if (_targetEntityID == value)
				{
					return;
				}
				_targetEntityID = value;
				PropertySet(this);
			}
		}

		public QuestStopFollowingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
