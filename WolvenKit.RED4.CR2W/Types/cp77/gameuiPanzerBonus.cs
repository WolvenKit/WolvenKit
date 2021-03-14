using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerBonus : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CFloat _fallingSpeed;

		[Ordinal(1)] 
		[RED("fallingSpeed")] 
		public CFloat FallingSpeed
		{
			get
			{
				if (_fallingSpeed == null)
				{
					_fallingSpeed = (CFloat) CR2WTypeManager.Create("Float", "fallingSpeed", cr2w, this);
				}
				return _fallingSpeed;
			}
			set
			{
				if (_fallingSpeed == value)
				{
					return;
				}
				_fallingSpeed = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerBonus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
