using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCompiledNode : worldNode
	{
		private Box _aabb;

		[Ordinal(4)] 
		[RED("aabb")] 
		public Box Aabb
		{
			get
			{
				if (_aabb == null)
				{
					_aabb = (Box) CR2WTypeManager.Create("Box", "aabb", cr2w, this);
				}
				return _aabb;
			}
			set
			{
				if (_aabb == value)
				{
					return;
				}
				_aabb = value;
				PropertySet(this);
			}
		}

		public worldTrafficCompiledNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
