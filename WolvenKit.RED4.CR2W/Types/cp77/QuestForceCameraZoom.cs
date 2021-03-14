using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestForceCameraZoom : ActionBool
	{
		private CBool _useWorkspot;

		[Ordinal(25)] 
		[RED("useWorkspot")] 
		public CBool UseWorkspot
		{
			get
			{
				if (_useWorkspot == null)
				{
					_useWorkspot = (CBool) CR2WTypeManager.Create("Bool", "useWorkspot", cr2w, this);
				}
				return _useWorkspot;
			}
			set
			{
				if (_useWorkspot == value)
				{
					return;
				}
				_useWorkspot = value;
				PropertySet(this);
			}
		}

		public QuestForceCameraZoom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
