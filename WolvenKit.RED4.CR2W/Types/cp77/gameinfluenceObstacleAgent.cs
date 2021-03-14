using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceObstacleAgent : gameinfluenceIAgent
	{
		private CBool _useMeshes;
		private CFloat _radius;

		[Ordinal(0)] 
		[RED("useMeshes")] 
		public CBool UseMeshes
		{
			get
			{
				if (_useMeshes == null)
				{
					_useMeshes = (CBool) CR2WTypeManager.Create("Bool", "useMeshes", cr2w, this);
				}
				return _useMeshes;
			}
			set
			{
				if (_useMeshes == value)
				{
					return;
				}
				_useMeshes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public gameinfluenceObstacleAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
