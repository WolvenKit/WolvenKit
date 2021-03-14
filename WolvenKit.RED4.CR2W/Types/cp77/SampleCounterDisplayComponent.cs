using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleCounterDisplayComponent : gameScriptableComponent
	{
		private gamePersistentID _targetPersistentID;

		[Ordinal(5)] 
		[RED("targetPersistentID")] 
		public gamePersistentID TargetPersistentID
		{
			get
			{
				if (_targetPersistentID == null)
				{
					_targetPersistentID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "targetPersistentID", cr2w, this);
				}
				return _targetPersistentID;
			}
			set
			{
				if (_targetPersistentID == value)
				{
					return;
				}
				_targetPersistentID = value;
				PropertySet(this);
			}
		}

		public SampleCounterDisplayComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
