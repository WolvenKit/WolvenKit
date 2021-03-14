using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleInteractiveEntityThatBumpsTheCounter : gameObject
	{
		private NodeRef _targetEntityWithCounter;
		private gamePersistentID _targetPersistentID;

		[Ordinal(40)] 
		[RED("targetEntityWithCounter")] 
		public NodeRef TargetEntityWithCounter
		{
			get
			{
				if (_targetEntityWithCounter == null)
				{
					_targetEntityWithCounter = (NodeRef) CR2WTypeManager.Create("NodeRef", "targetEntityWithCounter", cr2w, this);
				}
				return _targetEntityWithCounter;
			}
			set
			{
				if (_targetEntityWithCounter == value)
				{
					return;
				}
				_targetEntityWithCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
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

		public SampleInteractiveEntityThatBumpsTheCounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
