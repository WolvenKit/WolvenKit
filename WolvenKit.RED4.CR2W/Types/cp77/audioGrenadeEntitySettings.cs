using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGrenadeEntitySettings : audioEntitySettings
	{
		private CName _explosionSound;

		[Ordinal(6)] 
		[RED("explosionSound")] 
		public CName ExplosionSound
		{
			get
			{
				if (_explosionSound == null)
				{
					_explosionSound = (CName) CR2WTypeManager.Create("CName", "explosionSound", cr2w, this);
				}
				return _explosionSound;
			}
			set
			{
				if (_explosionSound == value)
				{
					return;
				}
				_explosionSound = value;
				PropertySet(this);
			}
		}

		public audioGrenadeEntitySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
