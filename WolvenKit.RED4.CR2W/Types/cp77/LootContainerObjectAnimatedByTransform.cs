using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootContainerObjectAnimatedByTransform : gameContainerObjectBase
	{
		private CBool _wasOpened;

		[Ordinal(51)] 
		[RED("wasOpened")] 
		public CBool WasOpened
		{
			get
			{
				if (_wasOpened == null)
				{
					_wasOpened = (CBool) CR2WTypeManager.Create("Bool", "wasOpened", cr2w, this);
				}
				return _wasOpened;
			}
			set
			{
				if (_wasOpened == value)
				{
					return;
				}
				_wasOpened = value;
				PropertySet(this);
			}
		}

		public LootContainerObjectAnimatedByTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
