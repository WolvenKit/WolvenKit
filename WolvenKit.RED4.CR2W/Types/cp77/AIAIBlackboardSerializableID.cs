using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAIBlackboardSerializableID : CVariable
	{
		private gameBlackboardSerializableID _id;

		[Ordinal(0)] 
		[RED("id")] 
		public gameBlackboardSerializableID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (gameBlackboardSerializableID) CR2WTypeManager.Create("gameBlackboardSerializableID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public AIAIBlackboardSerializableID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
