using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageIndicatorGameController : gameuiHUDGameController
	{
		private CUInt8 _maxVisibleParts;

		[Ordinal(9)] 
		[RED("maxVisibleParts")] 
		public CUInt8 MaxVisibleParts
		{
			get
			{
				if (_maxVisibleParts == null)
				{
					_maxVisibleParts = (CUInt8) CR2WTypeManager.Create("Uint8", "maxVisibleParts", cr2w, this);
				}
				return _maxVisibleParts;
			}
			set
			{
				if (_maxVisibleParts == value)
				{
					return;
				}
				_maxVisibleParts = value;
				PropertySet(this);
			}
		}

		public gameuiDamageIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
