using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerEnteredNewDistrictEvent : redEvent
	{
		private CFloat _gunshotRange;
		private CFloat _explosionRange;

		[Ordinal(0)] 
		[RED("gunshotRange")] 
		public CFloat GunshotRange
		{
			get
			{
				if (_gunshotRange == null)
				{
					_gunshotRange = (CFloat) CR2WTypeManager.Create("Float", "gunshotRange", cr2w, this);
				}
				return _gunshotRange;
			}
			set
			{
				if (_gunshotRange == value)
				{
					return;
				}
				_gunshotRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("explosionRange")] 
		public CFloat ExplosionRange
		{
			get
			{
				if (_explosionRange == null)
				{
					_explosionRange = (CFloat) CR2WTypeManager.Create("Float", "explosionRange", cr2w, this);
				}
				return _explosionRange;
			}
			set
			{
				if (_explosionRange == value)
				{
					return;
				}
				_explosionRange = value;
				PropertySet(this);
			}
		}

		public PlayerEnteredNewDistrictEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
