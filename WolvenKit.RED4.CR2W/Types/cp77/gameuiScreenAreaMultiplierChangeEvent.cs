using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiScreenAreaMultiplierChangeEvent : redEvent
	{
		private CFloat _screenAreaMultiplier;

		[Ordinal(0)] 
		[RED("screenAreaMultiplier")] 
		public CFloat ScreenAreaMultiplier
		{
			get
			{
				if (_screenAreaMultiplier == null)
				{
					_screenAreaMultiplier = (CFloat) CR2WTypeManager.Create("Float", "screenAreaMultiplier", cr2w, this);
				}
				return _screenAreaMultiplier;
			}
			set
			{
				if (_screenAreaMultiplier == value)
				{
					return;
				}
				_screenAreaMultiplier = value;
				PropertySet(this);
			}
		}

		public gameuiScreenAreaMultiplierChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
