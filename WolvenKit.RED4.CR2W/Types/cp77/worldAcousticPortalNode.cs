using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticPortalNode : worldNode
	{
		private CUInt8 _radius;
		private CUInt8 _nominalRadius;

		[Ordinal(4)] 
		[RED("radius")] 
		public CUInt8 Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CUInt8) CR2WTypeManager.Create("Uint8", "radius", cr2w, this);
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

		[Ordinal(5)] 
		[RED("nominalRadius")] 
		public CUInt8 NominalRadius
		{
			get
			{
				if (_nominalRadius == null)
				{
					_nominalRadius = (CUInt8) CR2WTypeManager.Create("Uint8", "nominalRadius", cr2w, this);
				}
				return _nominalRadius;
			}
			set
			{
				if (_nominalRadius == value)
				{
					return;
				}
				_nominalRadius = value;
				PropertySet(this);
			}
		}

		public worldAcousticPortalNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
