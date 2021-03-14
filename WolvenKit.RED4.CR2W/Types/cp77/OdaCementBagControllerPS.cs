using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OdaCementBagControllerPS : ScriptableDeviceComponentPS
	{
		private CFloat _cementEffectCooldown;

		[Ordinal(103)] 
		[RED("cementEffectCooldown")] 
		public CFloat CementEffectCooldown
		{
			get
			{
				if (_cementEffectCooldown == null)
				{
					_cementEffectCooldown = (CFloat) CR2WTypeManager.Create("Float", "cementEffectCooldown", cr2w, this);
				}
				return _cementEffectCooldown;
			}
			set
			{
				if (_cementEffectCooldown == value)
				{
					return;
				}
				_cementEffectCooldown = value;
				PropertySet(this);
			}
		}

		public OdaCementBagControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
