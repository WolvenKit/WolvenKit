using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSimpleSphere : senseIShape
	{
		private Sphere _sphere;

		[Ordinal(1)] 
		[RED("sphere")] 
		public Sphere Sphere
		{
			get
			{
				if (_sphere == null)
				{
					_sphere = (Sphere) CR2WTypeManager.Create("Sphere", "sphere", cr2w, this);
				}
				return _sphere;
			}
			set
			{
				if (_sphere == value)
				{
					return;
				}
				_sphere = value;
				PropertySet(this);
			}
		}

		public senseSimpleSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
