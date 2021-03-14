using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLightBlockingComponent : entIVisualComponent
	{
		private CFloat _radius;
		private CUInt8 _lightBlockerComponentVersion;

		[Ordinal(8)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lightBlockerComponentVersion")] 
		public CUInt8 LightBlockerComponentVersion
		{
			get
			{
				if (_lightBlockerComponentVersion == null)
				{
					_lightBlockerComponentVersion = (CUInt8) CR2WTypeManager.Create("Uint8", "lightBlockerComponentVersion", cr2w, this);
				}
				return _lightBlockerComponentVersion;
			}
			set
			{
				if (_lightBlockerComponentVersion == value)
				{
					return;
				}
				_lightBlockerComponentVersion = value;
				PropertySet(this);
			}
		}

		public entLightBlockingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
