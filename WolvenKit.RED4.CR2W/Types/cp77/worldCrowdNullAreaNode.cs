using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCrowdNullAreaNode : worldAreaShapeNode
	{
		private CBool _isForBlockade;

		[Ordinal(6)] 
		[RED("IsForBlockade")] 
		public CBool IsForBlockade
		{
			get
			{
				if (_isForBlockade == null)
				{
					_isForBlockade = (CBool) CR2WTypeManager.Create("Bool", "IsForBlockade", cr2w, this);
				}
				return _isForBlockade;
			}
			set
			{
				if (_isForBlockade == value)
				{
					return;
				}
				_isForBlockade = value;
				PropertySet(this);
			}
		}

		public worldCrowdNullAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
