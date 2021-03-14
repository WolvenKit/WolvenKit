using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphData : IScriptable
	{
		private CBool _changed;

		[Ordinal(0)] 
		[RED("changed")] 
		public CBool Changed
		{
			get
			{
				if (_changed == null)
				{
					_changed = (CBool) CR2WTypeManager.Create("Bool", "changed", cr2w, this);
				}
				return _changed;
			}
			set
			{
				if (_changed == value)
				{
					return;
				}
				_changed = value;
				PropertySet(this);
			}
		}

		public MorphData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
