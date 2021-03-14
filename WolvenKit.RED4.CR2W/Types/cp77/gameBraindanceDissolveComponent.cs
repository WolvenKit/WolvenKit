using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBraindanceDissolveComponent : entIComponent
	{
		private CFloat _dissolveRadius;

		[Ordinal(3)] 
		[RED("dissolveRadius")] 
		public CFloat DissolveRadius
		{
			get
			{
				if (_dissolveRadius == null)
				{
					_dissolveRadius = (CFloat) CR2WTypeManager.Create("Float", "dissolveRadius", cr2w, this);
				}
				return _dissolveRadius;
			}
			set
			{
				if (_dissolveRadius == value)
				{
					return;
				}
				_dissolveRadius = value;
				PropertySet(this);
			}
		}

		public gameBraindanceDissolveComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
