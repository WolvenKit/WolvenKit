using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponReloadSpeedData : animAnimFeature
	{
		private CFloat _reloadSpeed;
		private CFloat _emptyReloadSpeed;

		[Ordinal(0)] 
		[RED("reloadSpeed")] 
		public CFloat ReloadSpeed
		{
			get
			{
				if (_reloadSpeed == null)
				{
					_reloadSpeed = (CFloat) CR2WTypeManager.Create("Float", "reloadSpeed", cr2w, this);
				}
				return _reloadSpeed;
			}
			set
			{
				if (_reloadSpeed == value)
				{
					return;
				}
				_reloadSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("emptyReloadSpeed")] 
		public CFloat EmptyReloadSpeed
		{
			get
			{
				if (_emptyReloadSpeed == null)
				{
					_emptyReloadSpeed = (CFloat) CR2WTypeManager.Create("Float", "emptyReloadSpeed", cr2w, this);
				}
				return _emptyReloadSpeed;
			}
			set
			{
				if (_emptyReloadSpeed == value)
				{
					return;
				}
				_emptyReloadSpeed = value;
				PropertySet(this);
			}
		}

		public AnimFeature_WeaponReloadSpeedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
