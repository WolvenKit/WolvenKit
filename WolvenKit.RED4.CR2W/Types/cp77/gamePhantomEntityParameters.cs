using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhantomEntityParameters : CVariable
	{
		private CName _teleportStartEffect;
		private CName _teleportEndEffect;
		private CName _spawnEffect;
		private CName _glitchEffect;

		[Ordinal(0)] 
		[RED("teleportStartEffect")] 
		public CName TeleportStartEffect
		{
			get
			{
				if (_teleportStartEffect == null)
				{
					_teleportStartEffect = (CName) CR2WTypeManager.Create("CName", "teleportStartEffect", cr2w, this);
				}
				return _teleportStartEffect;
			}
			set
			{
				if (_teleportStartEffect == value)
				{
					return;
				}
				_teleportStartEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("teleportEndEffect")] 
		public CName TeleportEndEffect
		{
			get
			{
				if (_teleportEndEffect == null)
				{
					_teleportEndEffect = (CName) CR2WTypeManager.Create("CName", "teleportEndEffect", cr2w, this);
				}
				return _teleportEndEffect;
			}
			set
			{
				if (_teleportEndEffect == value)
				{
					return;
				}
				_teleportEndEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spawnEffect")] 
		public CName SpawnEffect
		{
			get
			{
				if (_spawnEffect == null)
				{
					_spawnEffect = (CName) CR2WTypeManager.Create("CName", "spawnEffect", cr2w, this);
				}
				return _spawnEffect;
			}
			set
			{
				if (_spawnEffect == value)
				{
					return;
				}
				_spawnEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("glitchEffect")] 
		public CName GlitchEffect
		{
			get
			{
				if (_glitchEffect == null)
				{
					_glitchEffect = (CName) CR2WTypeManager.Create("CName", "glitchEffect", cr2w, this);
				}
				return _glitchEffect;
			}
			set
			{
				if (_glitchEffect == value)
				{
					return;
				}
				_glitchEffect = value;
				PropertySet(this);
			}
		}

		public gamePhantomEntityParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
