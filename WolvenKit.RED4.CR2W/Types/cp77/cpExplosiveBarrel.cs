using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpExplosiveBarrel : gameDestructibleObject
	{
		private CName _colliderComponentName;
		private CName _destructionComponentName;

		[Ordinal(41)] 
		[RED("colliderComponentName")] 
		public CName ColliderComponentName
		{
			get
			{
				if (_colliderComponentName == null)
				{
					_colliderComponentName = (CName) CR2WTypeManager.Create("CName", "colliderComponentName", cr2w, this);
				}
				return _colliderComponentName;
			}
			set
			{
				if (_colliderComponentName == value)
				{
					return;
				}
				_colliderComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("destructionComponentName")] 
		public CName DestructionComponentName
		{
			get
			{
				if (_destructionComponentName == null)
				{
					_destructionComponentName = (CName) CR2WTypeManager.Create("CName", "destructionComponentName", cr2w, this);
				}
				return _destructionComponentName;
			}
			set
			{
				if (_destructionComponentName == value)
				{
					return;
				}
				_destructionComponentName = value;
				PropertySet(this);
			}
		}

		public cpExplosiveBarrel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
