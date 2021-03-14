using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IconsInstance : ModuleInstance
	{
		private CBool _isForcedVisibleThroughWalls;

		[Ordinal(6)] 
		[RED("isForcedVisibleThroughWalls")] 
		public CBool IsForcedVisibleThroughWalls
		{
			get
			{
				if (_isForcedVisibleThroughWalls == null)
				{
					_isForcedVisibleThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "isForcedVisibleThroughWalls", cr2w, this);
				}
				return _isForcedVisibleThroughWalls;
			}
			set
			{
				if (_isForcedVisibleThroughWalls == value)
				{
					return;
				}
				_isForcedVisibleThroughWalls = value;
				PropertySet(this);
			}
		}

		public IconsInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
