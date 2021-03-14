using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entStaticOrientationProvider : entIOrientationProvider
	{
		private Quaternion _staticOrientation;

		[Ordinal(0)] 
		[RED("staticOrientation")] 
		public Quaternion StaticOrientation
		{
			get
			{
				if (_staticOrientation == null)
				{
					_staticOrientation = (Quaternion) CR2WTypeManager.Create("Quaternion", "staticOrientation", cr2w, this);
				}
				return _staticOrientation;
			}
			set
			{
				if (_staticOrientation == value)
				{
					return;
				}
				_staticOrientation = value;
				PropertySet(this);
			}
		}

		public entStaticOrientationProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
