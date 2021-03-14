using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveEnteredSplineEvent : redEvent
	{
		private CBool _useDoors;

		[Ordinal(0)] 
		[RED("useDoors")] 
		public CBool UseDoors
		{
			get
			{
				if (_useDoors == null)
				{
					_useDoors = (CBool) CR2WTypeManager.Create("Bool", "useDoors", cr2w, this);
				}
				return _useDoors;
			}
			set
			{
				if (_useDoors == value)
				{
					return;
				}
				_useDoors = value;
				PropertySet(this);
			}
		}

		public moveEnteredSplineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
