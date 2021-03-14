using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTaskDefinition : ISerializable
	{
		private CBool _ignoreTaskCompletion;

		[Ordinal(0)] 
		[RED("ignoreTaskCompletion")] 
		public CBool IgnoreTaskCompletion
		{
			get
			{
				if (_ignoreTaskCompletion == null)
				{
					_ignoreTaskCompletion = (CBool) CR2WTypeManager.Create("Bool", "ignoreTaskCompletion", cr2w, this);
				}
				return _ignoreTaskCompletion;
			}
			set
			{
				if (_ignoreTaskCompletion == value)
				{
					return;
				}
				_ignoreTaskCompletion = value;
				PropertySet(this);
			}
		}

		public AIbehaviorTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
