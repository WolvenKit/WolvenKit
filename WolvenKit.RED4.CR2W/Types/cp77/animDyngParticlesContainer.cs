using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngParticlesContainer : CVariable
	{
		private Vector3 _externalForceWS;
		private animVectorLink _externalForceWsLink;
		private CArray<animDyngParticle> _particles;
		private CFloat _gravityWS;

		[Ordinal(0)] 
		[RED("externalForceWS")] 
		public Vector3 ExternalForceWS
		{
			get
			{
				if (_externalForceWS == null)
				{
					_externalForceWS = (Vector3) CR2WTypeManager.Create("Vector3", "externalForceWS", cr2w, this);
				}
				return _externalForceWS;
			}
			set
			{
				if (_externalForceWS == value)
				{
					return;
				}
				_externalForceWS = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("externalForceWsLink")] 
		public animVectorLink ExternalForceWsLink
		{
			get
			{
				if (_externalForceWsLink == null)
				{
					_externalForceWsLink = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "externalForceWsLink", cr2w, this);
				}
				return _externalForceWsLink;
			}
			set
			{
				if (_externalForceWsLink == value)
				{
					return;
				}
				_externalForceWsLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("particles")] 
		public CArray<animDyngParticle> Particles
		{
			get
			{
				if (_particles == null)
				{
					_particles = (CArray<animDyngParticle>) CR2WTypeManager.Create("array:animDyngParticle", "particles", cr2w, this);
				}
				return _particles;
			}
			set
			{
				if (_particles == value)
				{
					return;
				}
				_particles = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gravityWS")] 
		public CFloat GravityWS
		{
			get
			{
				if (_gravityWS == null)
				{
					_gravityWS = (CFloat) CR2WTypeManager.Create("Float", "gravityWS", cr2w, this);
				}
				return _gravityWS;
			}
			set
			{
				if (_gravityWS == value)
				{
					return;
				}
				_gravityWS = value;
				PropertySet(this);
			}
		}

		public animDyngParticlesContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
