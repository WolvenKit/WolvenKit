using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetChancePrereq : gameIScriptablePrereq
	{
		private CFloat _setChance;

		[Ordinal(0)] 
		[RED("setChance")] 
		public CFloat SetChance
		{
			get
			{
				if (_setChance == null)
				{
					_setChance = (CFloat) CR2WTypeManager.Create("Float", "setChance", cr2w, this);
				}
				return _setChance;
			}
			set
			{
				if (_setChance == value)
				{
					return;
				}
				_setChance = value;
				PropertySet(this);
			}
		}

		public SetChancePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
