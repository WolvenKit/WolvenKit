using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SurveillanceSystemControllerPS : DeviceSystemBaseControllerPS
	{
		private CBool _isRevealingEnemies;

		[Ordinal(105)] 
		[RED("isRevealingEnemies")] 
		public CBool IsRevealingEnemies
		{
			get
			{
				if (_isRevealingEnemies == null)
				{
					_isRevealingEnemies = (CBool) CR2WTypeManager.Create("Bool", "isRevealingEnemies", cr2w, this);
				}
				return _isRevealingEnemies;
			}
			set
			{
				if (_isRevealingEnemies == value)
				{
					return;
				}
				_isRevealingEnemies = value;
				PropertySet(this);
			}
		}

		public SurveillanceSystemControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
