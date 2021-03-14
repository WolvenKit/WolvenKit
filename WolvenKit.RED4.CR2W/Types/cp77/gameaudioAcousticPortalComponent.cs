using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioAcousticPortalComponent : entIPlacedComponent
	{
		private CUInt8 _radius;
		private CUInt8 _nominalRadius;
		private CBool _initialyOpen;

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("initialyOpen")] 
		public CBool InitialyOpen
		{
			get
			{
				if (_initialyOpen == null)
				{
					_initialyOpen = (CBool) CR2WTypeManager.Create("Bool", "initialyOpen", cr2w, this);
				}
				return _initialyOpen;
			}
			set
			{
				if (_initialyOpen == value)
				{
					return;
				}
				_initialyOpen = value;
				PropertySet(this);
			}
		}

		public gameaudioAcousticPortalComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
